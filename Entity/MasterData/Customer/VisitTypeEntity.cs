using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class VisitTypeEntity
    {
        public Int32 visit_type_id { get; set; }
        public String visit_type { get; set; }
        public DateTime create_date { get; set; }
        public Int32 create_by { get; set; }
        public DateTime modify_date { get; set; }
        public Int32 modify_by { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }
    }
}
