using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class InventoryLogEntity
    {
        public Int32 inventory_log_id { get; set; }
        public Int32 inventory_id { get; set; }
        public Int32 branch_id { get; set; }
        public String name { get; set; }
        public Int32 qty { get; set; }
        
        public String sku { get; set; }
        public String serial { get; set; }

        public Int32 type_id { get; set; }

        public Int32 category_id { get; set; }

        public Int32 create_by { get; set; }
        public DateTime create_date { get; set; }
        public String modify_by { get; set; }
        public DateTime modify_date { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }

        //develop parameter
        public String Inbound = "Inbound";
        public String OutBound = "OutBound";
        //parameter to save 
        public String updateMode { get; set; } //Inbound , OutBound
        public List<InventoryLogEntity> inventoryLogEntityList { get; set; }
    }
}
