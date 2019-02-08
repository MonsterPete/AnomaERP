using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class BranchBedEntity
    {
        public Int32 bed_id { get; set; }
        public Int32 room_id { get; set; }
        public String bed_name { get; set; }
        public DateTime create_date { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }

        #region room TB
        public Int32 floor_id { get; set; }
        #endregion
    }
}
