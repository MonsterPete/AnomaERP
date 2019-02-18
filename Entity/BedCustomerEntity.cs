using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class BedCustomerEntity
    {
        public Int32 bed_customer_id { get; set; }
        public Int32 customer_id { get; set; }
        public Int32 bed_id { get; set; }
        public Int32 status_bed_id { get; set; }
        public DateTime create_date { get; set; }
        public Int32 create_by { get; set; }
        public DateTime modify_date { get; set; }
        public Int32 modify_by { get; set; }
        public Boolean is_active { get; set; }

        public String branch_name { get; set; }
        public Int32 branch_id { get; set; }
        public String floor_name { get; set; }
        public String room_name { get; set; }
        public String bed_name { get; set; }
        public String fullname { get; set; }
        public String lastname { get; set; }
        public String firstname { get; set; }
        public Boolean is_have_customer { get; set; }

        #region Care Plan
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        #endregion
    }
}
