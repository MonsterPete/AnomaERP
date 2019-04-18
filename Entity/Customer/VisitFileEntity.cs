using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Visit_fileEntity
    {
        public Int32 visit_file_id { get; set; }
        public Int32 visit_id { get; set; }
        public String file_name { get; set; }
        public String url { get; set; }
        public DateTime created_date { get; set; }
        public Int32 created_by { get; set; }
        public DateTime modified_date { get; set; }
        public Int32 modified_by { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }
        public Int32 pageNumber { get; set; }
        public Int32 pageSize { get; set; }
    }
}
