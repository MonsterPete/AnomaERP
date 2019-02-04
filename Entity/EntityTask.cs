using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class EntityTask
    {
        public Int32 task_id { get; set; }
        public String task_name { get; set; }
        public String description { get; set; }
        public Int32 entity_id { get; set; }
        public Int32 create_by { get; set; }
        public DateTime create_date { get; set; }
        public Int32 modify_by { get; set; }
        public DateTime modify_date { get; set; }
    }
}
