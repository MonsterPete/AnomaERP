using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class InventoryEntity
    {
        public Int32 inventory_id { get; set; }
        public Int32 branch_id { get; set; }
        public String name { get; set; }
        public Int32 qty { get; set; }
        public String sku { get; set; }
        public String serial { get; set; }

        public Int32 type_id { get; set; }
        public String type_name { get; set; }

        public Int32 category_id { get; set; }
        public String category_name { get; set; }

        public Int32 create_by { get; set; }
        public DateTime create_date { get; set; }
        public String modify_by { get; set; }
        public DateTime modify_date { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }
    }
}
