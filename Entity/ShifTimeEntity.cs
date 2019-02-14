using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class ShifTimeEntity
    {
        public Int32 shif_time_id { get; set; }
        public Int32 employee_id { get; set; }
        public TimeSpan start_time_1 { get; set; }
        public TimeSpan end_time_1 { get; set; }
        public TimeSpan start_time_2 { get; set; }
        public TimeSpan end_time_2 { get; set; }
        public TimeSpan start_time_3 { get; set; }
        public TimeSpan end_time_3 { get; set; }
        public Int32 create_by { get; set; }
        public DateTime create_date { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }

    }
}
