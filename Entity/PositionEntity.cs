using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class PositionEntity
    {
        public Int32 position_id { get; set; }
        public Int32 group_id { get; set; }
        public String position_name { get; set; }
        public Int32 create_by { get; set; }
        public DateTime create_date { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }
    }
}
