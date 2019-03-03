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
        public Int32 qty_total { get; set; }

        //parameter for outbound
        public Int32 qty_outbound { get; set; }
        
        public String sku { get; set; }
        public String serial { get; set; }

        public Int32 type_id { get; set; }
        public String type_name { get; set; }

        public Int32 category_id { get; set; }
        public String category_name { get; set; }

        public Int32 create_by { get; set; }
        public DateTime create_date { get; set; }
        public Int32 modify_by { get; set; }
        public DateTime modify_date { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }

        //develop parameter
        //parameter to remove data from resultList
        public String temp_inventory_id { get; set; }

        public String Inbound = "Inbound";
        public String OutBound = "OutBound";
        //parameter to save 
        public String updateMode { get; set; } //Inbound , OutBound
        public List<InventoryEntity> inventoryEntityList { get; set; }


        public String s_create_date { get; set; }
        public String flag { get; set; }

        public Int32 Bed_inventory_id { get; set; }
        public Int32 Bed_id { get; set; }
        public Boolean Active { get; set; }
        public Int32 qty_return { get; set; }
    }
}
