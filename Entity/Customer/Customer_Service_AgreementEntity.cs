using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Customer_service_agreementEntity
    {
        public Int32 Customer_service_agreement_id { get; set; }
        public Int32 Customer_id { get; set; }
        public Decimal Month_service_cost { get; set; }
        public Decimal Diaper_commutation_cost { get; set; }
        public Decimal Dressing_equipment_commutation_cost { get; set; }
        public Decimal Customer_reservations_cost { get; set; }
        public Decimal Customer_balance_cost { get; set; }
        public DateTime Create_date { get; set; }
        public string Remark { get; set; }
        public Int32 PageNumber { get; set; }
        public Int32 PageSize { get; set; }
    }
}
