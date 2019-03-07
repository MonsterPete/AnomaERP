using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Entity
{
    public class DailyActivitiesEntity
    {
        public Int32 daily_activities_id { get; set; }
        public Int32 day_activities_id { get; set; }
        public Int32 care_plan_id { get; set; }
        public Int32 employee_id { get; set; }
        public bool is_done { get; set; }
        public bool timestamp { get; set; }
        public String commnet { get; set; }

        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        public Int32 task_id { get; set; }
        public String task_name { get; set; }
        public DateTime daily_date { get; set; }
        public String employee_firstname { get; set; }
        public String employee_lastname { get; set; }
        public bool can_reject { get; set; }

        public Int32 sch_customer_id { get; set; }
    }
}
