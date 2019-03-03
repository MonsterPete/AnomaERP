using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class CarePlanEntity
    {
        public Int32 care_plan_id { get; set; }
        public Int32 customer_id { get; set; }
        public DateTime start_time { get; set; }
        public String working_time { get; set; }
        public DateTime end_time { get; set; }
        public Int32 task_id { get; set; }
        public Boolean is_delete { get; set; }

        public String task_name { get; set; }
    }
}
