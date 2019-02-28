using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class DailyActivitiesEntity
    {
        public Int32 daily_activities_id { get; set; }
        public Int32 care_plan_id { get; set; }
        public Int32 employee_id { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        public String comment { get; set; }
        public DateTime action_date { get; set; }
        public DateTime create_date { get; set; }
        public Boolean is_delete { get; set; }
    }
}
