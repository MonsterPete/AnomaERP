using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using Service.Customer;
using Service.EntityTask;
using Service.ServiceCare;

namespace AnomaERP.BackOffice.ServiceCare
{
    public partial class schedule_management : System.Web.UI.Page
    {
        public static List<EntityTaskEntity> eTaskList = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblEmployeeID.Text = "7";
                if (Request.QueryString["Employee_ID"] != null)
                {
                    if (int.Parse(Request.QueryString["Employee_ID"]) > 0)
                    {
                        lblEmployeeID.Text = Request.QueryString["Employee_ID"].ToString();
                    }
                }
                SetEntityTask(int.Parse(lblEmployeeID.Text));
            }
        }

        protected void SetEntityTask(int employeeID)
        {
            EntityTaskService service = new EntityTaskService();
            eTaskList = new List<EntityTaskEntity>();
            eTaskList = service.GetDataByEmployee(employeeID);
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            setDataToUI(setCondition());
        }
        protected void rptList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            DailyActivitiesEntity entity = (DailyActivitiesEntity)e.Item.DataItem;
            Label lblDailyDate = (Label)e.Item.FindControl("lblDailyDate");
            Label lblStartTime = (Label)e.Item.FindControl("lblStartTime");
            Label lblEndTime = (Label)e.Item.FindControl("lblEndTime");
            Label lblJob = (Label)e.Item.FindControl("lblJob");
            Label lblTakeCareBy = (Label)e.Item.FindControl("lblTakeCareBy");

            LinkButton lbnAccept = (LinkButton)e.Item.FindControl("lbnAccept");
            LinkButton lbnIsTakeCare = (LinkButton)e.Item.FindControl("lbnIsTakeCare");
            LinkButton lbnReject = (LinkButton)e.Item.FindControl("lbnReject");


            lblDailyDate.Text = entity.daily_date.ToString("dd'/'MM'/'yyyy");
            lblStartTime.Text = entity.start_time.ToString("dd'/'MM'/'yyyy");
            lblEndTime.Text = entity.end_time.ToString("dd'/'MM'/'yyyy");
            lblJob.Text = entity.task_name;

            String takeCareBy = "";
            if (entity.employee_firstname != null)
            {
                takeCareBy += entity.employee_firstname;
            }
            if (entity.employee_lastname != null)
            {
                takeCareBy += " "+entity.employee_lastname;
            }
            lblTakeCareBy.Text = takeCareBy;
            // *****เช็คสิทธิ์แสดงปุ่ม Takecare
            if (entity.employee_id != 0)
            {
                lbnAccept.Visible = false;
                lbnIsTakeCare.Visible = true;
                // **ถ้า employeeID == entity.employeeID และวัน >= new Date() แสดงปุ่ม X
                if (entity.employee_id == int.Parse(lblEmployeeID.Text) && entity.can_reject == true)
                {
                    lbnReject.Visible = true;
                }
            }
            else
            {
                lbnAccept.Visible = true;
                lbnIsTakeCare.Visible = false;
                lbnReject.Visible = false;
            }

            lbnAccept.CommandName = "Accept";
            lbnAccept.CommandArgument = entity.daily_activities_id.ToString();

            lbnReject.CommandName = "Reject";
            lbnReject.CommandArgument = entity.daily_activities_id.ToString();
        }

        protected void rptList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int success = 0;
            if (e.CommandName == "Accept")
            {
                //***UPDATE Daily_Activities set EmployeeId AND ETC.
                DailyActivitiesEntity entity = new DailyActivitiesEntity();
                DailyAactivitiesService service = new DailyAactivitiesService();
                entity.daily_activities_id = int.Parse(e.CommandArgument.ToString());
                entity.employee_id = int.Parse(lblEmployeeID.Text);

                success = service.UpdateDataAccept(entity);
            }
            if (e.CommandName == "Reject") //ปุ่ม X
            {
                //***UPDATE Daily_Activities set EmployeeId = null AND ETC.
                DailyActivitiesEntity entity = new DailyActivitiesEntity();
                DailyAactivitiesService service = new DailyAactivitiesService();
                entity.daily_activities_id = int.Parse(e.CommandArgument.ToString());
                entity.employee_id = int.Parse(lblEmployeeID.Text);

                success = service.UpdateDataReject(entity);
            }
           
            if (success > 0)
            {
                // **Refresh Table
                setDataToUI(setCondition());
            }
            else
            {
                //Suma Alert Update Fail
            }
        }

        public void setDataToUI(DailyActivitiesEntity entity)
        {
            if (entity.sch_customer_id != 0)
            {
                CustomerService cService = new CustomerService();
                CustomerEntity cEntity = cService.GetDataByID(entity.sch_customer_id);

                txtCustomerName.Text = cEntity.firstname + " " + cEntity.lastname;
                txtBranch.Text = cEntity.branch_name;
                txtStartDate.Text = cEntity.contract_start.ToString("dd'/'MM'/'yyyy"); ;
                txtEndDate.Text = cEntity.contract_end.ToString("dd'/'MM'/'yyyy"); ;

                DailyAactivitiesService service = new DailyAactivitiesService();
                List<DailyActivitiesEntity> entityList = new List<DailyActivitiesEntity>();
                entityList = service.GetDataByCustomer(entity.sch_customer_id);
                resultList.DataSource = entityList;
                resultList.DataBind();
            }
            else
            {
                //Suma Alert IsValid = false
            }
        }
        private bool checkValid()
        {
            Boolean unValid = false, valid = true;
            String customer_id = txtCustomerId.Text;

            //Check Empty
            unValid |= String.IsNullOrEmpty(customer_id);
            unValid |= !Regex.IsMatch(customer_id, @"\d");
            valid = !unValid;
            return valid;
        }
        public DailyActivitiesEntity setCondition()
        {
            DailyActivitiesEntity entity = new DailyActivitiesEntity();
            if (checkValid())
            {
                entity.sch_customer_id = int.Parse(txtCustomerId.Text.Trim());
            }
            else
            {
                entity.sch_customer_id = 0;
            }

            return entity;
        }
    }
}