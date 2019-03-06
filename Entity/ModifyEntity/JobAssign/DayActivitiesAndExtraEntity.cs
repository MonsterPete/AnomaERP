using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class DayActivitiesAndExtraEntity
    {
        public Int32 day_activities_id { get; set; }
        public DateTime daily_date { get; set; }
        public Int32 extra_activities_id { get; set; }
        public Int32 task_id { get; set; }
        public String task_name { get; set; }
        public TimeSpan start_time { get; set; }
        public TimeSpan end_time { get; set; }
    }
}
