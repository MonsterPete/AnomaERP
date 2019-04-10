using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class PersonalFactorsEntity
    {
        public Int32 customer_id { get; set; }

        public Int32 personal_factors_id { get; set; }
        public String personal_factors_name { get; set; }
        public DateTime created_date { get; set; }
        public Int32 created_by { get; set; }
        public DateTime modified_date { get; set; }
        public Int32 modified_by { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }
    }
}
