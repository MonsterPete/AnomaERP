using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Customer_relativeEntity
    {
        public Int32 Customer_relative_id { get; set; }
        public Int32 Customer_id { get; set; }
        public String Customer_relative_name { get; set; }
        public String Customer_relative_phone { get; set; }
        public String Customer_relation { get; set; }
        public Int32 PageNumber { get; set; }
        public Int32 PageSize { get; set; }
    }
}
