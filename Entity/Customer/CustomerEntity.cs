using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Entity
{
    public class CustomerEntity
    {
        public Int32 customer_id { get; set; }
        public Int32 branch_id { get; set; }
        public String fullname { get; set; }
        public String firstname { get; set; }
        public String lastname { get; set; }
        public String id_card { get; set; }
        public String general_information_upload { get; set; }
        public DateTime DOB { get; set; }
        public String gender { get; set; }
        public DateTime contract_start { get; set; }
        public DateTime contract_end { get; set; }
        public Boolean is_have_bed { get; set; }
        public DateTime create_date { get; set; }
        public Int32 create_by { get; set; }
        public DateTime modify_date { get; set; }
        public Int32 modify_by { get; set; }
        public Int32 age { get; set; }
        public Boolean martial_status { get; set; }
        public String address { get; set; }
        public Int32 sub_district { get; set; }
        public Int32 district { get; set; }
        public Int32 province { get; set; }
        public String zipcode { get; set; }
        public String tel { get; set; }
        public String information_channel { get; set; }
        public String current_illness { get; set; }
        public String current_illness_history { get; set; }
        public String doctor_diagnosis { get; set; }
        public String treatment_has_received { get; set; }
        public Boolean is_surgery { get; set; }
        public String surgery_comment { get; set; }
        public Boolean is_admit { get; set; }
        public Boolean is_delete { get; set; }

        public String branch_name { get; set; }
        public Customer_information_recieveEntity customer_Information_RecieveEntity { get; set; }
        public CustomerRelativeEntity customer_RelativeEntity { get; set; }
        public CustomerServiceAgreementEntity customer_Service_AgreementEntity { get; set; }
        public Customer_vital_signEntity customer_Vital_SignEntity { get; set; }

        public List<CustomerCongenitalDiseaseEntity> customerCongenitalDiseaseEntities { get; set; }
        public List<CustomerRedFlagEntity> customerRedFlagEntities { get; set; }
        public List<CustomerRiskAssessmentEntity> customerRiskAssessmentEntities { get; set; }
        public List<CustomerPersonalFactorsEntity> customerPersonalFactorsEntities { get; set; }
    }
}
