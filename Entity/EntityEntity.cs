using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class EntityEntity
    {
        public Int32 entity_id { get; set; }
        public String entity_name { get; set; }
        public String logo { get; set; }
        public String address { get; set; }
        public String register_address { get; set; }
        public String tax_id { get; set; }
        public String perfix { get; set; }
        public String phone { get; set; }
        public String email { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public Int32 create_by { get; set; }
        public DateTime create_date { get; set; }
        public Int32 modify_by { get; set; }
        public DateTime modify_date { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }

        public Boolean? is_active_search { get; set; }
    }
}
