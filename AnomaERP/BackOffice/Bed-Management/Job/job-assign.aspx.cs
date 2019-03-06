using Definitions;
using Service.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnomaERP.BackOffice.Bed_Management.Job
{
    public partial class job_assign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TimeFormat timeFormat = new TimeFormat();
            ddlStartHour.DataSource = timeFormat.GenHour();
            ddlStartHour.DataTextField = "values";
            ddlStartHour.DataValueField = "values";
            ddlStartHour.DataBind();

            ddlStartMinute.DataSource = timeFormat.GenMinutes();
            ddlStartMinute.DataTextField = "values";
            ddlStartMinute.DataValueField = "values";
            ddlStartMinute.DataBind();

            ddlEndHour.DataSource = timeFormat.GenHour();
            ddlEndHour.DataTextField = "values";
            ddlEndHour.DataValueField = "values";
            ddlEndHour.DataBind();

            ddlEndMinute.DataSource = timeFormat.GenMinutes();
            ddlEndMinute.DataTextField = "values";
            ddlEndMinute.DataValueField = "values";
            ddlEndMinute.DataBind();

            EntityTaskService entityTaskService = new EntityTaskService(); 
            ddlTask.DataSource = entityTaskService.GetDataAll();
            ddlTask.DataTextField = "task_name";
            ddlTask.DataValueField = "task_id";
            ddlTask.DataBind();

            //Session["CarePlan"] = getcareplan;
            //Session["DayActivities"] = getDayActivitiesAndExtraActivities;

            // var groupedCustomerList = userList
            //.GroupBy(u => u.GroupID)
            //.Select(grp => grp.ToList())
            //.ToList();
        }

        protected void RptDayActivities_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lblDate = (Label)e.Item.FindControl("lblDate");
        }

        protected void RptDailyActivities_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lblDailyTime = (Label)e.Item.FindControl("lblDailyTime");
            Label lblDailyTask = (Label)e.Item.FindControl("lblDailyTask");
        }

        protected void RptExtraActivities_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lblExtraTime = (Label)e.Item.FindControl("lblExtraTime");
            Label lblExtraTask = (Label)e.Item.FindControl("lblExtraTask");
        }

        protected void lbnComfirm_Click(object sender, EventArgs e)
        {

        }
    }
}