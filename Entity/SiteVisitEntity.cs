using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SiteVisitEntity
    {
        public Int32 visitor_id { get; set; }
        public Int32 branch_id { get; set; }
        public String firstname { get; set; }
        public String lastname { get; set; }
        public String revice_from { get; set; }
        public String phone { get; set; }
        public String comment { get; set; }
        public DateTime date_of_visit { get; set; }
        public DateTime date_of_appointment { get; set; }
        public Int32 price_listed { get; set; }
        public String symptom { get; set; }
        public Boolean reservation { get; set; }

        //Search Field
        public String sch_customer_name { get; set; }
        public Boolean sch_reservation { get; set; }
    }
}
