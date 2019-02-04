using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class BuildingTypeEntity
    {
        public Int32 building_type_id { get; set; }
        public String building_type_name { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }
    }
}
