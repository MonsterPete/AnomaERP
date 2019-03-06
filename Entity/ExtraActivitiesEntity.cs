using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class ExtraActivitiesEntity
    {
        public Int32 extra_activities_id { get; set; }
        public Int32 day_activities_id { get; set; }
        public Int32 task_id { get; set; }
        public TimeSpan start_time { get; set; }
        public TimeSpan end_time { get; set; }
        public Int32 employee_id { get; set; }
        public Boolean is_done { get; set; }
        public DateTime timestamp { get; set; }
        public String comment { get; set; }
    }
}
