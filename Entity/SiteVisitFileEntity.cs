using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SiteVisitFileEntity
    {
        public Int32 site_visit_file_id { get; set; }
        public Int32 visitor_id { get; set; }
        public String file_name { get; set; }
        public String url { get; set; }
        public DateTime created_date { get; set; }
        public Int32 created_by { get; set; }
        public DateTime modified_date { get; set; }
        public Int32 modified_by { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }
    }
}
