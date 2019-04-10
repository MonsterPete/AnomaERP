using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class CongenitalDiseaseEntity
    {
        public Int32 congenital_disease_id { get; set; }
        public String congenital_disease_name { get; set; }
        public DateTime created_date { get; set; }
        public Int32 created_by { get; set; }
        public DateTime modified_date { get; set; }
        public Int32 modified_by { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }
        
        public Int32 customer_id { get; set; }
    }
}
