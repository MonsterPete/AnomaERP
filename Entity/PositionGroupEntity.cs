﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class PositionGroupEntity
    {
        public Int32 entity_id { get; set; }
        public Int32 group_id { get; set; }
        public String group_name { get; set; }
        public Int32 create_by { get; set; }
        public DateTime create_date { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }
    }
}
