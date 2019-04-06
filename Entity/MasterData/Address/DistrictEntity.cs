﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class DistrictEntity
    {
        public Int32 district_id { get; set; }
        public Int32 province_id { get; set; }
        public String district_name { get; set; }
        public DateTime created_date { get; set; }
        public Int32 created_by { get; set; }
        public DateTime modified_date { get; set; }
        public Int32 modified_by { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }
    }
}
