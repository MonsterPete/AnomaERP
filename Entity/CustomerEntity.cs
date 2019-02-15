using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class CustomerEntity
    {
        public Int32 customer_id { get; set; }
        public Int32 branch_id { get; set; }
        public String fullname { get; set; }
        public String firstname { get; set; }
        public String lastname { get; set; }
        public String general_information_upload { get; set; }
        public String DOB { get; set; }
        public String gender { get; set; }
        public DateTime contract_start { get; set; }
        public DateTime contract_end { get; set; }
        public Boolean is_have_bed { get; set; }
        public DateTime create_date { get; set; }
        public Int32 create_by { get; set; }
        public DateTime modify_date { get; set; }
        public Int32 modify_by { get; set; }
    }
}
