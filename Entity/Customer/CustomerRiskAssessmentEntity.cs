using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class CustomerRiskAssessmentEntity
    {
        public Int32 customer_risk_assessment_id { get; set; }
        public Int32 customer_id { get; set; }
        public Int32 risk_assessment_id { get; set; }
        public DateTime created_date { get; set; }
        public Int32 created_by { get; set; }
        public DateTime modified_date { get; set; }
        public Int32 modified_by { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_delete { get; set; }
    }
}
