using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class BranchBed
    {
        public Int32 bed_id { get; set; }
        public Int32 bed_type_id { get; set; }
        public Int32 branch_id { get; set; }
        public String bed_type_name { get; set; }
        public DateTime create_date { get; set; }
        public Boolean is_delete { get; set; }
    }
}
