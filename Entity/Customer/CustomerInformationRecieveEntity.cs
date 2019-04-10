using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Customer_information_recieveEntity
    {
        public Int32 customer_information_recieve_id { get; set; }
        public Int32 customer_id { get; set; }
        public DateTime customer_information_recieve_date { get; set; }
        public Int32 customer_information_recieve_service_by { get; set; }
        public String other { get; set; }
        public String important_documents { get; set; }
        public Int32 PageNumber { get; set; }
        public Int32 PageSize { get; set; }
    }
}
