﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Customer
{
    public class VisitEntity
    {
        public Int32 visit_id { get; set; }
        public Int32 customer_id { get; set; }
        public String visit_code { get; set; }
        public Int32 visit_type { get; set; }
        public DateTime create_date { get; set; }

        public Int32 running_number_id { get; set; }
        public Int32 branch_id { get; set; }
    }
}
