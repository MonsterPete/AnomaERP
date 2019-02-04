using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class ShifTimeEntity
    {
        public Int32 shif_time_id { get; set; }
        public Int32 employee_id { get; set; }
        //        NULL
        //        NULL
        //NULL
        //NULL
        //NULL
        //NULL
        public Int32 create_by { get; set; }
        public DateTime create_date { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }
    }
}
