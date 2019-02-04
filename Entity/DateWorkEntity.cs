using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class DateWorkEntity
    {
        public Int32 date_work_id { get; set; }
        public Int32 employee_id { get; set; }
        public Boolean monday { get; set; }
        public Boolean tuesday { get; set; }
        public Boolean wednesday { get; set; }
        public Boolean thuresday { get; set; }
        public Boolean friday { get; set; }
        public Boolean saturday { get; set; }
        public Boolean sunday { get; set; }
        public DateTime create_date { get; set; }
        public Boolean create_by { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }
    }
}
