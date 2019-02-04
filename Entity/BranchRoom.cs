using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class BranchRoom
    {
        public Int32 room_id { get; set; }
        public Int32 floor_id { get; set; }
        public String room_name { get; set; }
        public DateTime create_date { get; set; }
        public Boolean is_delete { get; set; }
    }
}
