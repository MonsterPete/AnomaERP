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
    }
}
