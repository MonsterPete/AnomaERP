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

            DayActivities dayActivities = new DayActivities();
            ExtraActivitiesEntity extraActivitiesEntity = new ExtraActivitiesEntity();
            DayActivitiesService dayActivitiesService = new DayActivitiesService();
            List<DayActivitiesAndExtraEntity> dayActivitiesAndExtraEntities = new List<DayActivitiesAndExtraEntity>();
            dayActivities.customer_id = 7;
            dayActivitiesAndExtraEntities = dayActivitiesService.GetDayAndExtraByCondition(dayActivities);

            CarePlanService carePlanService = new CarePlanService();
            Session["carePlanEntity"] = carePlanService.GetDataByCustomerId(7);
            Session["dayActivitiesAndExtraEntities"] = dayActivitiesAndExtraEntities;

            List<DayActivities> dayActivitiesListRpt = new List<DayActivities>();
            var dayActivitiesList = dayActivitiesAndExtraEntities
           .GroupBy(u => u.day_activities_id)
           .Select(grp => grp.ToList())
           .ToList();

            for (int i = 0;i < dayActivitiesList.Count;i++)
            {
                dayActivitiesListRpt.Add(new DayActivities {
                    day_activities_id = dayActivitiesList[i][0].day_activities_id,
                    daily_date = dayActivitiesList[i][0].daily_date
                });
            }

            RptDayActivities.DataSource = dayActivitiesListRpt;
            RptDayActivities.DataBind();
        }

        protected void RptDayActivities_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            DayActivities dayActivities = (DayActivities)e.Item.DataItem;
            Label lblDate = (Label)e.Item.FindControl("lblDate");
            Repeater RptDailyActivities = (Repeater)e.Item.FindControl("RptDailyActivities");
            Repeater RptExtraActivities = (Repeater)e.Item.FindControl("RptExtraActivities");

            RptDailyActivities.DataSource = (List<CarePlanEntity>)Session["carePlanEntity"];
            RptDailyActivities.DataBind();
            lblDate.Text = dayActivities.daily_date.ToString("dd-MM-yyyy");

            List<DayActivitiesAndExtraEntity> dayActivitiesAndExtraEntities = (List<DayActivitiesAndExtraEntity>)Session["dayActivitiesAndExtraEntities"];

            var extraEntities = dayActivitiesAndExtraEntities
                .Where(ad => ad.day_activities_id == dayActivities.day_activities_id && ad.task_id > 0)
                .ToList();

            List<DayActivitiesAndExtraEntity> RptDayActivitiesAndExtraEntities = new List<DayActivitiesAndExtraEntity>();
            if (extraEntities.Count > 0)
            {
                for (int i = 0; i < extraEntities.Count; i++)
                {
                    RptDayActivitiesAndExtraEntities.Add(new DayActivitiesAndExtraEntity
                    {
                        task_name = extraEntities[i].task_name,
                        task_id = extraEntities[i].task_id,
                        start_time = extraEntities[i].start_time,
                        end_time = extraEntities[i].end_time
                    });
                }

                RptExtraActivities.DataSource = RptDayActivitiesAndExtraEntities;
                RptExtraActivities.DataBind();
            }
        }

        protected void RptDailyActivities_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            CarePlanEntity dayActivitiesAndExtraEntity = (CarePlanEntity)e.Item.DataItem;
            Label lblDailyTime = (Label)e.Item.FindControl("lblDailyTime");
            Label lblDailyTask = (Label)e.Item.FindControl("lblDailyTask");

            lblDailyTime.Text = dayActivitiesAndExtraEntity.start_time.ToString("hh:mm tt") + " - " + dayActivitiesAndExtraEntity.end_time.ToString("hh:mm tt");
            lblDailyTask.Text = dayActivitiesAndExtraEntity.task_name;
        }

        protected void RptExtraActivities_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            DayActivitiesAndExtraEntity dayActivitiesAndExtraEntity = (DayActivitiesAndExtraEntity)e.Item.DataItem;
            Label lblExtraTime = (Label)e.Item.FindControl("lblExtraTime");
            Label lblExtraTask = (Label)e.Item.FindControl("lblExtraTask");

            DateTime timeStart = DateTime.Today.Add(dayActivitiesAndExtraEntity.start_time);
            DateTime timeEnd = DateTime.Today.Add(dayActivitiesAndExtraEntity.end_time);

            lblExtraTime.Text = timeStart.ToString("hh:mm tt") + " - " + timeEnd.ToString("hh:mm tt");
            lblExtraTask.Text = dayActivitiesAndExtraEntity.task_name;
        }

        protected void lbnComfirm_Click(object sender, EventArgs e)
        {

        }
    }
}