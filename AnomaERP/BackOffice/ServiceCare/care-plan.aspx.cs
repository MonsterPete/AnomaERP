using Definitions;
using Entity;
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
            HiddenField hdfTaskId = (HiddenField)e.Item.FindControl("hdfTaskId");
            LinkButton lbnDelete = (LinkButton)e.Item.FindControl("lbnDelete");

            lblStartTime.Text = entity.start_time.ToString("HH-MM");
            lblEndTime.Text = entity.end_time.ToString("HH-MM");
            lblTask.Text = entity.task_name;
            hdfTaskId.Value = entity.task_id.ToString();

            lbnDelete.CommandName = "Delete";
            lbnDelete.CommandArgument = entity.care_plan_id.ToString();
        }

        protected void rptCarePlan_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void lbnAdd_Click(object sender, EventArgs e)
        {
            DateFormat dateFormat = new DateFormat();
            List<CarePlanEntity> carePlanEntities = GetDataFromRpt();
            carePlanEntities.Add(new CarePlanEntity {
                start_time = Convert.ToDateTime(txtStartTime.Text),
                end_time = Convert.ToDateTime(txtEndtime.Text),
                task_id = int.Parse(ddlTask.SelectedValue),
                task_name = ddlTask.SelectedItem.ToString(),
                is_delete = false
            });

            SetDataToRpt(carePlanEntities);
        }

        private List<CarePlanEntity> GetDataFromRpt()
        {
            List<CarePlanEntity> carePlanEntities = new List<CarePlanEntity>();
            for (int i = 0; i < rptCarePlan.Items.Count; i++)
            {
                CarePlanEntity carePlanRptEntity = new CarePlanEntity();
                Label lblStartTime = (Label)rptCarePlan.Items[i].FindControl("lblStartTime");
                Label lblEndTime = (Label)rptCarePlan.Items[i].FindControl("lblEndTime");
                Label lblTask = (Label)rptCarePlan.Items[i].FindControl("lblTask");
                HiddenField hdfTaskId = (HiddenField)rptCarePlan.Items[i].FindControl("hdfTaskId");

                if (!rptCarePlan.Items[i].Visible)
                {
                    carePlanRptEntity.is_delete = true; 
                }
                carePlanEntities.Add(carePlanRptEntity);
            }

            return carePlanEntities;
        }
    }
}