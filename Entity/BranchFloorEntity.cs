using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class BranchFloorEntity
    {
        public Int32 floor_id { get; set; }
        public Int32 branch_id { get; set; }
        public String floor_name { get; set; }
        public DateTime create_date { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }
    }
}
