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
        public bool? sch_reservation { get; set; }


        //communication
        public Int32 site_visite_communication_id { get; set; }
        public Boolean is_facebook { get; set; }
        public Boolean is_magazine { get; set; }
        public Boolean is_advertise { get; set; }
        public Boolean is_youtube { get; set; }
        public Boolean is_biilboard { get; set; }
        public Boolean is_recommend { get; set; }
        public Boolean is_other { get; set; }
        public String comment_other { get; set; }
    }
}
