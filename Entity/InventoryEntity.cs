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
        //parameter for search inventory
        public int qty_on_hand { get; set; }

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

        //search parameter
        public String sch_word { get; set; }
        public int? sch_branch_id { get; set; }
        public int? sch_category_id { get; set; }

        //develop parameter
        //parameter to remove data from resultList
        public String temp_inventory_id { get; set; }

        public String Inbound = "Inbound";
        public String OutBound = "OutBound";
        //parameter to save 
        public String updateMode { get; set; } //Inbound , OutBound
        public List<InventoryEntity> inventoryEntityList { get; set; }
    }
}
