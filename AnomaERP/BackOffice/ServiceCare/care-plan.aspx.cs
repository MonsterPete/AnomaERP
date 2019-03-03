using Definitions;
using Entity;
using Service.Role;
using Service.ServiceCare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnomaERP.BackOffice.ServiceCare
{
    public partial class care_plan : System.Web.UI.Page
    {
        //start_time = dateFormat.EngFormatDateToSQL(txtStartTime.Text)
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EntityTaskService entityTaskService = new EntityTaskService();
                TimeFormat timeFormat = new TimeFormat();
                ddlHour.DataSource = timeFormat.GenHour();
                ddlHour.DataTextField = "values";
                ddlHour.DataValueField = "values";
                ddlHour.DataBind();

                ddlMinute.DataSource = timeFormat.GenMinutes();
                ddlMinute.DataTextField = "values";
                ddlMinute.DataValueField = "values";
                ddlMinute.DataBind();

                ddlTask.DataSource = entityTaskService.GetDataAll();
                ddlTask.DataTextField = "task_name";
                ddlTask.DataValueField = "task_id";
                ddlTask.DataBind();

                CarePlanService carePlanService = new CarePlanService();

                SetDataToRpt(carePlanService.GetDataByCustomerId(int.Parse(Request.QueryString["customerId"].ToString())));
            }
        }

        private void SetDataToRpt(List<CarePlanEntity> carePlanEntities)
        {
            rptCarePlan.DataSource = carePlanEntities;
            rptCarePlan.DataBind();
        }

        protected void rptCarePlan_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            CarePlanEntity entity = (CarePlanEntity)e.Item.DataItem;
            
            Label lblStartTime = (Label)e.Item.FindControl("lblStartTime");
            Label lblEndTime = (Label)e.Item.FindControl("lblEndTime");
            Label lblTask = (Label)e.Item.FindControl("lblTask");
            Label lblWorkingTime = (Label)e.Item.FindControl("lblWorkingTime");
            HiddenField hdfTaskId = (HiddenField)e.Item.FindControl("hdfTaskId");
            LinkButton lbnDelete = (LinkButton)e.Item.FindControl("lbnDelete");

            lblWorkingTime.Text = entity.working_time;
            lblStartTime.Text = entity.start_time.ToString("hh:mm tt");
            lblEndTime.Text = entity.end_time.ToString("hh:mm tt");
            lblTask.Text = entity.task_name;
            hdfTaskId.Value = entity.task_id.ToString();


            lbnDelete.CommandName = "Delete";
            lbnDelete.CommandArgument = entity.care_plan_id.ToString();

            if (entity.is_delete)
            {
                e.Item.Visible = false;
            }
        }

        protected void rptCarePlan_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                e.Item.Visible = false;
            }
        }

        protected void lbnAdd_Click(object sender, EventArgs e)
        {
            TimeFormat timeFormat = new TimeFormat();
            
            List<CarePlanEntity> carePlanEntities = GetDataFromRpt();
            carePlanEntities.Add(new CarePlanEntity {
                start_time = timeFormat.ConvertDataToTime(ddlHour.SelectedValue.ToString(), ddlMinute.SelectedValue.ToString(), ddlUnit.SelectedValue.ToString()),
                working_time = txtWorkingTime.Text,
                end_time = Convert.ToDateTime(txtEndtime.Text),
                task_id = int.Parse(ddlTask.SelectedValue),
                task_name = ddlTask.SelectedItem.ToString(),
                is_delete = false
            });

            SetDataToRpt(carePlanEntities);
        }

        private List<CarePlanEntity> GetDataFromRpt()
        {
            TimeFormat timeFormat = new TimeFormat();
            List<CarePlanEntity> carePlanEntities = new List<CarePlanEntity>();
            for (int i = 0; i < rptCarePlan.Items.Count; i++)
            {
                CarePlanEntity carePlanRptEntity = new CarePlanEntity();
                Label lblStartTime = (Label)rptCarePlan.Items[i].FindControl("lblStartTime");
                Label lblEndTime = (Label)rptCarePlan.Items[i].FindControl("lblEndTime");
                Label lblTask = (Label)rptCarePlan.Items[i].FindControl("lblTask");
                Label lblWorkingTime = (Label)rptCarePlan.Items[i].FindControl("lblWorkingTime");
                HiddenField hdfTaskId = (HiddenField)rptCarePlan.Items[i].FindControl("hdfTaskId");
                LinkButton lbnDelete = (LinkButton)rptCarePlan.Items[i].FindControl("lbnDelete");

                carePlanRptEntity.customer_id = int.Parse(Request.QueryString["customerId"].ToString());
                carePlanRptEntity.care_plan_id = int.Parse(lbnDelete.CommandArgument);
                carePlanRptEntity.working_time = lblWorkingTime.Text;
                carePlanRptEntity.start_time = Convert.ToDateTime(lblStartTime.Text);
                carePlanRptEntity.end_time = Convert.ToDateTime(lblEndTime.Text);
                carePlanRptEntity.task_name = lblTask.Text;
                carePlanRptEntity.task_id = int.Parse(hdfTaskId.Value);
                if (!rptCarePlan.Items[i].Visible)
                {
                    carePlanRptEntity.is_delete = true; 
                }
                carePlanEntities.Add(carePlanRptEntity);
            }

            return carePlanEntities;
        }

        protected void txtWorkingTime_TextChanged(object sender, EventArgs e)
        {
            setDataToTxtWorkingTime();
        }

        private void setDataToTxtWorkingTime()
        {
            TimeFormat timeFormat = new TimeFormat();
            txtEndtime.Text = timeFormat.PlusTime(timeFormat.ConvertDataToTime(ddlHour.SelectedValue.ToString(), ddlMinute.SelectedValue.ToString(), ddlUnit.SelectedValue.ToString()), int.Parse(txtWorkingTime.Text)).ToString("hh:mm tt");
        }

        protected void ddlTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            setDataToTxtWorkingTime();
        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {
            CarePlanService carePlanService = new CarePlanService();
            carePlanService.InsertOrUpdateMoreData(GetDataFromRpt());
            Response.Redirect("/BackOffice/NursingHome/Bed-Reservation/bed-reserve-list.aspx");
        }

        protected void lblBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/BackOffice/NursingHome/Bed-Reservation/bed-reserve-list.aspx");
        }
    }
}