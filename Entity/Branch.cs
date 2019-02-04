using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Branch
    {
        public Int32 branch_id { get; set; }
        public Int32 entity_id { get; set; }
        public String branch_name { get; set; }
        public String address { get; set; }
        public String registor_address { get; set; }
        public String tax_id { get; set; }
        public String prefix { get; set; }
        public Int32 building_type_id { get; set; }
        public String usage_area { get; set; }
        public Decimal rental_price { get; set; }
        public String phone { get; set; }
        public String email { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public DateTime create_date { get; set; }
        public Int32 create_by { get; set; }
        public DateTime modify_date { get; set; }
        public Int32 modify_by { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }
    }
}
