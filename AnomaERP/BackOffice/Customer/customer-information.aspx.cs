﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Entity;
using Service;
using Service.Customer;

namespace AnomaERP.BackOffice.Customer
{
    public partial class customer_information : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblCustomerID.Text = "0";
                lblCustomerRelativeID.Text = "0";
                lblCustomerInformationRecieveID.Text = "0";
                lblCustomerVitalSignID.Text = "0";
                //SetDDLProvince();
                //SetDDLDistinct(int.Parse(ddlProvince.SelectedValue));
                //SetDDLSubDistinct(int.Parse(ddlDistrict.SelectedValue));

                //if (Request.QueryString["customer_id"] != null)
                //{

                //    if (int.Parse(Request.QueryString["customer_id"]) > 0)
                //    {
                //        lblCustomerID.Text = Request.QueryString["customer_id"].ToString();

                //    }
                //}
                GetDataToUI(int.Parse(lblCustomerID.Text));
            }
        }

        protected void ddlProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDDLDistinct(int.Parse(ddlProvince.SelectedValue));
        }

        protected void ddlDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDDLSubDistinct(int.Parse(ddlDistrict.SelectedValue));
        }

        public void SetDDLProvince()
        {
            List<ProvinceEntity> provinceEntities = new List<ProvinceEntity>();
            ProvinceService provinceService = new ProvinceService();

            provinceEntities = provinceService.GetDataAll();
            provinceEntities.Insert(0, new ProvinceEntity
            {
                province_id = 0,
                province_name = "-select-"
            });

            ddlProvince.DataSource = provinceEntities;
            ddlProvince.DataTextField = "province_name";
            ddlProvince.DataValueField = "province_id";
            ddlProvince.DataBind();
        }

        public void SetDDLDistinct(int province_id)
        {
            List<DistrictEntity> districtEntities = new List<DistrictEntity>();
            DistrictService districtService = new DistrictService();

            districtEntities = districtService.GetDataByProvinceID(province_id);

            districtEntities.Insert(0, new DistrictEntity
            {
                district_id = 0,
                district_name = "-select-"
            });

            ddlDistrict.DataSource = districtEntities;
            ddlDistrict.DataTextField = "district_name";
            ddlDistrict.DataValueField = "district_id";
            ddlDistrict.DataBind();
        }

        public void SetDDLSubDistinct(int district_id)
        {
            List<SubDistrictEntity> subDistrictEntities = new List<SubDistrictEntity>();
            SubDistrictService subDistrictService = new SubDistrictService();

            subDistrictEntities = subDistrictService.GetDataByDistrictID(district_id);
            subDistrictEntities.Insert(0, new SubDistrictEntity
            {
                sub_district_id = 0,
                sub_district_name = "-select-"
            });

            ddlSubDisctrict.DataSource = subDistrictEntities;
            ddlSubDisctrict.DataTextField = "sub_district_name";
            ddlSubDisctrict.DataValueField = "sub_district_id";
            ddlSubDisctrict.DataBind();
        }

        public void GetDataToUI(int customer_id)
        {
            CongenitalDiseaseService congenitalDiseaseService = new CongenitalDiseaseService();
            List<CongenitalDiseaseEntity> congenitalDiseaseEntities = new List<CongenitalDiseaseEntity>();
            CongenitalDiseaseEntity customerCongenitalDiseaseEntity = new CongenitalDiseaseEntity();
            customerCongenitalDiseaseEntity.customer_id = customer_id;
            congenitalDiseaseEntities = congenitalDiseaseService.GetDataByCondition(customerCongenitalDiseaseEntity);

            RedFlagService redFlagService = new RedFlagService();
            List<RedFlagEntity> redFlagEntities = new List<RedFlagEntity>();
            RedFlagEntity redFlagEntity = new RedFlagEntity();
            redFlagEntity.customer_id = customer_id;
            redFlagEntities = redFlagService.GetDataByCondition(redFlagEntity);

            RiskAssessmentService riskAssessmentService = new RiskAssessmentService();
            List<RiskAssessmentEntity> riskAssessmentEntities = new List<RiskAssessmentEntity>();
            RiskAssessmentEntity riskAssessmentEntity = new RiskAssessmentEntity();
            riskAssessmentEntity.customer_id = customer_id;
            riskAssessmentEntities = riskAssessmentService.GetDataByCondition(riskAssessmentEntity);

            PersonalFactorsService personalFactorsService = new PersonalFactorsService();
            List<PersonalFactorsEntity> personalFactorsEntities = new List<PersonalFactorsEntity>();
            PersonalFactorsEntity personalFactorsEntity = new PersonalFactorsEntity();
            personalFactorsEntity.customer_id = customer_id;
            personalFactorsEntities = personalFactorsService.GetDataByCondition(personalFactorsEntity);

            SetDataToUICongenitalDisease(congenitalDiseaseEntities);
            SetDataToUIRedFlag(redFlagEntities);
            SetDataToUIRiskAssessment(riskAssessmentEntities);
            SetDataToUIPersonalFactors(personalFactorsEntities);

            if (customer_id > 0)
            {
                CustomerService customerService = new CustomerService();
                CustomerEntity customerEntity = new CustomerEntity();
                customerEntity.customer_id = customer_id;
                customerEntity = customerService.GetDataByID(customer_id);
                SetDataToUICustomer(customerEntity);
            }
        }

        public void SetDataToUICongenitalDisease(List<CongenitalDiseaseEntity> customerCongenitalDiseaseEntities)
        {
            rptchkCongenitalDisease.DataSource = customerCongenitalDiseaseEntities;
            rptchkCongenitalDisease.DataBind();
        }

        public void SetDataToUIRedFlag(List<RedFlagEntity> customerRedFlagEntities)
        {
            rptchkRedFlag.DataSource = customerRedFlagEntities;
            rptchkRedFlag.DataBind();
        }

        public void SetDataToUIRiskAssessment(List<RiskAssessmentEntity> customerRiskAssessmentEntities)
        {
            rptRiskAssessment.DataSource = customerRiskAssessmentEntities;
            rptRiskAssessment.DataBind();
        }

        public void SetDataToUIPersonalFactors(List<PersonalFactorsEntity> customerPersonalFactorsEntities)
        {
            rptPersonalFactors.DataSource = customerPersonalFactorsEntities;
            rptPersonalFactors.DataBind();
        }

        protected void rptchkCongenitalDisease_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            CongenitalDiseaseEntity congenitalDiseaseEntity = (CongenitalDiseaseEntity)e.Item.DataItem;

            Label lblCongenitalDiseaseID = (Label)e.Item.FindControl("lblCongenitalDiseaseID");
            Label lblCustomerCongenitalDiseaseID = (Label)e.Item.FindControl("lblCustomerCongenitalDiseaseID");
            Label lblCongenitalDiseaseName = (Label)e.Item.FindControl("lblCongenitalDiseaseName");
            HtmlInputCheckBox isCheckCongenitalDisease = (HtmlInputCheckBox)e.Item.FindControl("isCheckCongenitalDisease");

            lblCongenitalDiseaseID.Text = congenitalDiseaseEntity.congenital_disease_id.ToString();
            lblCustomerCongenitalDiseaseID.Text = congenitalDiseaseEntity.customer_congenital_disease_id.ToString();
            lblCongenitalDiseaseName.Text = congenitalDiseaseEntity.congenital_disease_name;

            if (congenitalDiseaseEntity.customer_congenital_disease_id > 0)
            {
                isCheckCongenitalDisease.Checked = true;
            }
        }

        protected void rptchkRedFlag_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            RedFlagEntity redFlagEntity = (RedFlagEntity)e.Item.DataItem;

            Label lblRedFlagID = (Label)e.Item.FindControl("lblRedFlagID");
            Label lblCustomerRedFlagID = (Label)e.Item.FindControl("lblCustomerRedFlagID");
            Label lblRedFlagName = (Label)e.Item.FindControl("lblRedFlagName");
            HtmlInputCheckBox isRedFlag = (HtmlInputCheckBox)e.Item.FindControl("isRedFlag");

            lblCustomerRedFlagID.Text = redFlagEntity.customer_red_flag_id.ToString();
            lblRedFlagID.Text = redFlagEntity.red_flag_id.ToString();
            lblRedFlagName.Text = redFlagEntity.red_flag_name;

            if (redFlagEntity.customer_red_flag_id > 0)
            {
                isRedFlag.Checked = true;
            }
        }

        protected void rptRiskAssessment_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            RiskAssessmentEntity riskAssessmentEntity = (RiskAssessmentEntity)e.Item.DataItem;

            Label lblRiskAssessmentID = (Label)e.Item.FindControl("lblRiskAssessmentID");
            Label lblCustomerRiskAssessmentID = (Label)e.Item.FindControl("lblCustomerRiskAssessmentID");
            Label lblRiskAssessmentName = (Label)e.Item.FindControl("lblRiskAssessmentName");
            HtmlInputCheckBox isRiskAssessment = (HtmlInputCheckBox)e.Item.FindControl("isRiskAssessment");

            lblRiskAssessmentID.Text = riskAssessmentEntity.risk_assessment_id.ToString();
            lblCustomerRiskAssessmentID.Text = riskAssessmentEntity.customer_risk_assessment_id.ToString();
            lblRiskAssessmentName.Text = riskAssessmentEntity.risk_assessment_name;

            if (riskAssessmentEntity.customer_risk_assessment_id > 0)
            {
                isRiskAssessment.Checked = true;
            }
        }

        protected void rptPersonalFactors_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            PersonalFactorsEntity personalFactorsEntity = (PersonalFactorsEntity)e.Item.DataItem;

            Label lblPersonalFactorsID = (Label)e.Item.FindControl("lblPersonalFactorsID");
            Label lblCustomerPersonalFactorsID = (Label)e.Item.FindControl("lblCustomerPersonalFactorsID");
            Label lblPersonalFactorsName = (Label)e.Item.FindControl("lblPersonalFactorsName");
            HtmlInputCheckBox isPersonalFactors = (HtmlInputCheckBox)e.Item.FindControl("isPersonalFactors");

            lblPersonalFactorsID.Text = personalFactorsEntity.personal_factors_id.ToString();
            lblCustomerPersonalFactorsID.Text = personalFactorsEntity.customer_personal_factors_id.ToString();
            lblPersonalFactorsName.Text = personalFactorsEntity.personal_factors_name;

            if (personalFactorsEntity.customer_personal_factors_id > 0)
            {
                isPersonalFactors.Checked = true;
            }
        }

        public void SetDataToUICustomer(CustomerEntity customerEntity)
        {
            txtHN.Text = "";
            txtCreatedDate.Text = DateTime.Now.ToString();
            txtFirstName.Text = customerEntity.firstname;
            txtLastName.Text = customerEntity.lastname;
            txtTaxId.Text = customerEntity.id_card;
            txtDOB.Text = customerEntity.DOB.ToString();
            txtAge.Text = customerEntity.age.ToString();
            ddlSex.SelectedValue = customerEntity.gender;
            if (customerEntity.martial_status != null)
            {
                ddlMartialStatus.SelectedValue = customerEntity.martial_status.ToString();
            }
            txtAddress.Text = customerEntity.address;
            ddlProvince.SelectedValue = customerEntity.province.ToString();
            ddlDistrict.SelectedValue = customerEntity.district.ToString();
            ddlSubDisctrict.SelectedValue = customerEntity.sub_district.ToString();
            txtZipCode.Text = customerEntity.zipcode;
            txtPhone.Text = customerEntity.tel;
            ddlNewFrom.SelectedValue = customerEntity.information_channel;

            lblCustomerRelativeID.Text = customerEntity.customer_RelativeEntity.customer_relative_id.ToString(); ;
            txtRelationName1.Text = customerEntity.customer_RelativeEntity.customer_relative_name_1;
            txtRelation1.Text = customerEntity.customer_RelativeEntity.customer_relation_1;
            txtRelationTel1.Text = customerEntity.customer_RelativeEntity.customer_relative_phone_1;
            txtRelationTelEmergency1.Text = customerEntity.customer_RelativeEntity.customer_relative_emergency_tel_1;
            txtRelationLine1.Text = customerEntity.customer_RelativeEntity.customer_relation_line_id_1;
            txtRelationFacebook1.Text = customerEntity.customer_RelativeEntity.customer_relation_facebook_1;
            txtRelationEmail1.Text = customerEntity.customer_RelativeEntity.customer_relation_email_1;
            txtRelationAddress1.Text = customerEntity.customer_RelativeEntity.customer_relation_address_1;

            txtRelationName2.Text = customerEntity.customer_RelativeEntity.customer_relative_name_2;
            txtRelation2.Text = customerEntity.customer_RelativeEntity.customer_relation_2;
            txtRelationTel2.Text = customerEntity.customer_RelativeEntity.customer_relative_phone_2;
            txtRelationTelEmergency2.Text = customerEntity.customer_RelativeEntity.customer_relative_emergency_tel_2;
            txtRelationLine2.Text = customerEntity.customer_RelativeEntity.customer_relation_line_id_2;
            txtRelationFacebook2.Text = customerEntity.customer_RelativeEntity.customer_relation_facebook_2;
            txtRelationEmail2.Text = customerEntity.customer_RelativeEntity.customer_relation_email_2;
            txtRelationAddress2.Text = customerEntity.customer_RelativeEntity.customer_relation_address_2;

            if (customerEntity.customer_Information_RecieveEntity != null)
            {
                lblCustomerInformationRecieveID.Text = customerEntity.customer_Information_RecieveEntity.customer_information_recieve_id.ToString();
                if (customerEntity.customer_Information_RecieveEntity.customer_information_recieve_date != null)
                {
                    txtDateInformationRecieve.Text = customerEntity.customer_Information_RecieveEntity.customer_information_recieve_date.ToString();
                    txtTimeInformationRecieve.Text = customerEntity.customer_Information_RecieveEntity.customer_information_recieve_date.ToLongTimeString();
                }

                if (customerEntity.customer_Information_RecieveEntity.customer_information_recieve_service_by == 1)
                {
                    rbtnServiceBy1.Attributes.Add("Checked", "true");
                }
                else if (customerEntity.customer_Information_RecieveEntity.customer_information_recieve_service_by == 2)
                {
                    rbtnServiceBy2.Attributes.Add("Checked", "true");
                }
                else if (customerEntity.customer_Information_RecieveEntity.customer_information_recieve_service_by == 3)
                {
                    rbtnServiceBy3.Attributes.Add("Checked", "true");
                }
                txtImportantDoc.Text = customerEntity.customer_Information_RecieveEntity.important_documents;
            }

            txtCurrentIllness.Text = customerEntity.current_illness;
            txtHistoryIllness.Text = customerEntity.current_illness_history;
            txtDiagnosis.Text = customerEntity.doctor_diagnosis;
            txtTreatment.Text = customerEntity.treatment_has_received;

            if (customerEntity.is_surgery == false)
            {
                rbtnTreatment1.Attributes.Add("Checked", "true");
            }
            else
            {
                rbtnTreatment2.Attributes.Add("Checked", "true");
                txtTreatment.Text = customerEntity.surgery_comment;
            }

            if (customerEntity.customer_Vital_SignEntity != null)
            {
                lblCustomerVitalSignID.Text = customerEntity.customer_Vital_SignEntity.customer_vital_sign_id.ToString();
                txtT_C.Text = customerEntity.customer_Vital_SignEntity.t_c.ToString("N2");
                txtP_Min.Text = customerEntity.customer_Vital_SignEntity.p_min.ToString("N2");
                txtR_Min.Text = customerEntity.customer_Vital_SignEntity.r_min.ToString("N2");
                txtBP_mmHg.Text = customerEntity.customer_Vital_SignEntity.bp_mmhg.ToString("N2");
                txtO2Sat_Percent.Text = customerEntity.customer_Vital_SignEntity.o2sat_percent.ToString("N2");
                txtBW_kg.Text = customerEntity.customer_Vital_SignEntity.bw_kg.ToString("N2");
                txtHT_Cm.Text = customerEntity.customer_Vital_SignEntity.ht_cm.ToString("N2");
                txtBMI_Index.Text = customerEntity.customer_Vital_SignEntity.bm_index.ToString("N2");
            }
        }

        public List<CustomerCongenitalDiseaseEntity> GetChkListCongenitalDisease()
        {
            List<CustomerCongenitalDiseaseEntity> customerCongenitalDiseaseEntities = new List<CustomerCongenitalDiseaseEntity>();

            for (int i = 0; i < rptchkCongenitalDisease.Items.Count; i++)
            {
                Label lblCongenitalDiseaseID = (Label)rptchkCongenitalDisease.Items[i].FindControl("lblCongenitalDiseaseID");
                Label lblCustomerCongenitalDiseaseID = (Label)rptchkCongenitalDisease.Items[i].FindControl("lblCustomerCongenitalDiseaseID");
                Label lblCongenitalDiseaseName = (Label)rptchkCongenitalDisease.Items[i].FindControl("lblCongenitalDiseaseName");
                HtmlInputCheckBox isCheckCongenitalDisease = (HtmlInputCheckBox)rptchkCongenitalDisease.Items[i].FindControl("isCheckCongenitalDisease");

                bool check = false;
                if (isCheckCongenitalDisease.Checked == true)
                {
                    check = true;
                }

                customerCongenitalDiseaseEntities.Add(new CustomerCongenitalDiseaseEntity
                {
                    customer_congenital_disease_id = int.Parse(lblCustomerCongenitalDiseaseID.Text),
                    congenital_disease_id = int.Parse(lblCongenitalDiseaseID.Text),
                    congenital_disease_name = lblCongenitalDiseaseName.Text,
                    customer_id = int.Parse(lblCustomerID.Text),
                    modified_by = 1,
                    modified_date = DateTime.Now,
                    is_check = check
                });
            }
            return customerCongenitalDiseaseEntities;
        }

        public List<CustomerRedFlagEntity> GetChkListRedFlag()
        {
            List<CustomerRedFlagEntity> customerRedFlagEntities = new List<CustomerRedFlagEntity>();

            for (int i = 0; i < rptchkRedFlag.Items.Count; i++)
            {
                Label lblRedFlagID = (Label)rptchkRedFlag.Items[i].FindControl("lblRedFlagID");
                Label lblCustomerRedFlagID = (Label)rptchkRedFlag.Items[i].FindControl("lblCustomerRedFlagID");
                Label lblRedFlagName = (Label)rptchkRedFlag.Items[i].FindControl("lblRedFlagName");
                HtmlInputCheckBox isRedFlag = (HtmlInputCheckBox)rptchkRedFlag.Items[i].FindControl("isRedFlag");

                bool check = false;
                if (isRedFlag.Checked == true)
                {
                    check = true;
                }

                customerRedFlagEntities.Add(new CustomerRedFlagEntity
                {
                    customer_red_flag_id = int.Parse(lblCustomerRedFlagID.Text),
                    red_flag_id = int.Parse(lblRedFlagID.Text),
                    customer_id = int.Parse(lblCustomerID.Text),
                    modified_by = 1,
                    modified_date = DateTime.Now,
                    is_check = check
                });
            }
            return customerRedFlagEntities;
        }

        public List<CustomerRiskAssessmentEntity> GetChkListRiskAssessment()
        {
            List<CustomerRiskAssessmentEntity> customerRiskAssessmentEntities = new List<CustomerRiskAssessmentEntity>();

            for (int i = 0; i < rptRiskAssessment.Items.Count; i++)
            {
                Label lblRiskAssessmentID = (Label)rptRiskAssessment.Items[i].FindControl("lblRiskAssessmentID");
                Label lblCustomerRiskAssessmentID = (Label)rptRiskAssessment.Items[i].FindControl("lblCustomerRiskAssessmentID");
                Label lblRiskAssessmentName = (Label)rptRiskAssessment.Items[i].FindControl("lblRiskAssessmentName");
                HtmlInputCheckBox isRiskAssessment = (HtmlInputCheckBox)rptRiskAssessment.Items[i].FindControl("isRiskAssessment");

                bool check = false;
                if (isRiskAssessment.Checked == true)
                {
                    check = true;
                }

                customerRiskAssessmentEntities.Add(new CustomerRiskAssessmentEntity
                {
                    customer_risk_assessment_id = int.Parse(lblCustomerRiskAssessmentID.Text),
                    risk_assessment_id = int.Parse(lblRiskAssessmentID.Text),
                    customer_id = int.Parse(lblCustomerID.Text),
                    modified_by = 1,
                    modified_date = DateTime.Now,
                    is_check = check
                });
            }
            return customerRiskAssessmentEntities;
        }

        public List<CustomerPersonalFactorsEntity> GetChkListPersonalFactor()
        {
            List<CustomerPersonalFactorsEntity> customerPersonalFactorsEntities = new List<CustomerPersonalFactorsEntity>();

            for (int i = 0; i < rptPersonalFactors.Items.Count; i++)
            {
                Label lblPersonalFactorsID = (Label)rptPersonalFactors.Items[i].FindControl("lblPersonalFactorsID");
                Label lblCustomerPersonalFactorsID = (Label)rptPersonalFactors.Items[i].FindControl("lblCustomerPersonalFactorsID");
                Label lblPersonalFactorsName = (Label)rptPersonalFactors.Items[i].FindControl("lblPersonalFactorsName");
                HtmlInputCheckBox isPersonalFactors = (HtmlInputCheckBox)rptPersonalFactors.Items[i].FindControl("isPersonalFactors");

                bool check = false;
                if (isPersonalFactors.Checked == true)
                {
                    check = true;
                }

                customerPersonalFactorsEntities.Add(new CustomerPersonalFactorsEntity
                {
                    customer_personal_factors_id = int.Parse(lblCustomerPersonalFactorsID.Text),
                    personal_factors_id = int.Parse(lblPersonalFactorsID.Text),
                    customer_id = int.Parse(lblCustomerID.Text),
                    modified_by = 1,
                    modified_date = DateTime.Now,
                    is_check = check
                });
            }
            return customerPersonalFactorsEntities;
        }

        public CustomerEntity getDataFromUI()
        {
            CustomerEntity customerEntity = new CustomerEntity();
            List<CustomerCongenitalDiseaseEntity> customerCongenitalDiseaseEntities = new List<CustomerCongenitalDiseaseEntity>();
            List<CustomerRedFlagEntity> customerRedFlagEntities = new List<CustomerRedFlagEntity>();
            List<CustomerRiskAssessmentEntity> customerRiskAssessmentEntities = new List<CustomerRiskAssessmentEntity>();
            List<CustomerPersonalFactorsEntity> customerPersonalFactorsEntities = new List<CustomerPersonalFactorsEntity>();

            txtHN.Text = "";
            customerEntity.create_date = DateTime.Parse(txtCreatedDate.Text);
            customerEntity.firstname = txtFirstName.Text;
            customerEntity.lastname = txtLastName.Text;
            customerEntity.id_card = txtTaxId.Text;
            customerEntity.DOB = DateTime.Parse(txtDOB.Text);
            customerEntity.age = int.Parse(txtAge.Text);
            customerEntity.gender = ddlSex.SelectedValue;
            customerEntity.martial_status = ddlMartialStatus.SelectedValue;
            customerEntity.address = txtAddress.Text;
            customerEntity.province = int.Parse(ddlProvince.SelectedValue);
            customerEntity.district = int.Parse(ddlDistrict.SelectedValue); ;
            customerEntity.sub_district = int.Parse(ddlSubDisctrict.SelectedValue);
            customerEntity.zipcode = txtZipCode.Text;
            customerEntity.tel = txtPhone.Text;
            customerEntity.information_channel = ddlNewFrom.SelectedValue;
            customerEntity.current_illness = txtCurrentIllness.Text;
            customerEntity.current_illness_history = txtHistoryIllness.Text;
            customerEntity.doctor_diagnosis = txtDiagnosis.Text;
            customerEntity.treatment_has_received = txtTreatment.Text;
            if (rbtnTreatment1.Checked == true)
            {
                customerEntity.is_surgery = false;
            }
            else
            {
                customerEntity.is_surgery = true;
                customerEntity.surgery_comment = txtTreatment.Text;
            }

            CustomerRelativeEntity customerRelativeEntity = new CustomerRelativeEntity();
            customerRelativeEntity.customer_relative_id = int.Parse(lblCustomerRelativeID.Text);
            customerRelativeEntity.customer_relative_name_1 = txtRelationName1.Text;
            customerRelativeEntity.customer_relation_1 = txtRelation1.Text;
            customerRelativeEntity.customer_relative_phone_1 = txtRelationTel1.Text;
            customerRelativeEntity.customer_relative_emergency_tel_1 = txtRelationTelEmergency1.Text;
            customerRelativeEntity.customer_relation_line_id_1 = txtRelationLine1.Text;
            customerRelativeEntity.customer_relation_facebook_1 =  txtRelationFacebook1.Text;
            customerRelativeEntity.customer_relation_email_1 = txtRelationEmail1.Text;
            customerRelativeEntity.customer_relation_address_1 = txtRelationAddress1.Text;
            customerRelativeEntity.customer_relative_name_2 = txtRelationName2.Text;
            customerRelativeEntity.customer_relation_2 = txtRelation2.Text;
            customerRelativeEntity.customer_relative_phone_2 = txtRelationTel2.Text;
            customerRelativeEntity.customer_relative_emergency_tel_2 = txtRelationTelEmergency2.Text;
            customerRelativeEntity.customer_relation_line_id_2 = txtRelationLine2.Text;
            customerRelativeEntity.customer_relation_facebook_2 = txtRelationFacebook2.Text;
            customerRelativeEntity.customer_relation_email_2 = txtRelationEmail2.Text;
            customerRelativeEntity.customer_relation_address_2 = txtRelationAddress2.Text;

            Customer_information_recieveEntity customer_Information_RecieveEntity = new Customer_information_recieveEntity();
            customer_Information_RecieveEntity.customer_information_recieve_id = int.Parse(lblCustomerInformationRecieveID.Text);
            customer_Information_RecieveEntity.customer_information_recieve_date = DateTime.Parse(txtDateInformationRecieve.Text);
            
            if (rbtnServiceBy1.Checked == true)
            {
                customer_Information_RecieveEntity.customer_information_recieve_service_by = 1;
            }
            else if (rbtnServiceBy1.Checked == true)
            {
                customer_Information_RecieveEntity.customer_information_recieve_service_by = 2;
            }
            else if (rbtnServiceBy1.Checked == true)
            {
                customer_Information_RecieveEntity.customer_information_recieve_service_by = 3;
            }
            customer_Information_RecieveEntity.important_documents = txtImportantDoc.Text;

            Customer_vital_signEntity customer_Vital_SignEntity = new Customer_vital_signEntity();
            customer_Vital_SignEntity.customer_vital_sign_id = int.Parse(lblCustomerVitalSignID.Text);
            customer_Vital_SignEntity.t_c = decimal.Parse(txtT_C.Text);
            customer_Vital_SignEntity.p_min = decimal.Parse(txtP_Min.Text);
            customer_Vital_SignEntity.r_min = decimal.Parse(txtR_Min.Text);
            customer_Vital_SignEntity.bp_mmhg = decimal.Parse(txtBP_mmHg.Text);
            customer_Vital_SignEntity.o2sat_percent = decimal.Parse(txtO2Sat_Percent.Text);
            customer_Vital_SignEntity.ht_cm = decimal.Parse(txtHT_Cm.Text);
            customer_Vital_SignEntity.bm_index = decimal.Parse(txtBMI_Index.Text);

            customerCongenitalDiseaseEntities = GetChkListCongenitalDisease();
            customerRedFlagEntities = GetChkListRedFlag();
            customerRiskAssessmentEntities = GetChkListRiskAssessment();
            customerPersonalFactorsEntities = GetChkListPersonalFactor();

            customerEntity.customer_RelativeEntity = customerRelativeEntity;
            customerEntity.customer_Information_RecieveEntity = customer_Information_RecieveEntity;
            customerEntity.customer_Vital_SignEntity = customer_Vital_SignEntity;
            customerEntity.customerCongenitalDiseaseEntities = customerCongenitalDiseaseEntities;
            customerEntity.customerRedFlagEntities = customerRedFlagEntities;
            customerEntity.customerRiskAssessmentEntities = customerRiskAssessmentEntities;
            customerEntity.customerPersonalFactorsEntities = customerPersonalFactorsEntities;

            return customerEntity;
        }

        protected void lbnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtLastName.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณากรอกชื่อ หรือนามสกุล (Name-Surname)');", true);
                return;
            }

            if (string.IsNullOrEmpty(txtTaxId.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณากรอกเลขที่บัตรประชาชน (ID Card)');", true);
                return;
            }

            if (string.IsNullOrEmpty(txtDOB.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณากรอกวันเดือนปีเกิด (DOB)');", true);
                return;
            }

            if (string.IsNullOrEmpty(txtAge.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณากรอกอายุ (Age)');", true);
                return;
            }

            if (ddlSex.SelectedValue == "0")
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาเลือกเพศ (Sex)');", true);
                return;
            }

            if (ddlMartialStatus.SelectedValue == "0")
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาเลือกสถานภาพ (Martial Status)');", true);
                return;
            }

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาระบุที่อยู่ปัจจุบัน (Address)');", true);
                return;
            }

            if (ddlProvince.SelectedValue == "0")
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาเลือกจังหวัด (Province)');", true);
                return;
            }

            if (ddlDistrict.SelectedValue == "0")
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาเลือกอำเภอ/เขต (District)');", true);
                return;
            }

            if (ddlSubDisctrict.SelectedValue == "0")
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาเลือกตำบล/แขวง (Sub-Disctrict)');", true);
                return;
            }

            if (string.IsNullOrEmpty(txtZipCode.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาระบุรหัสไปรษณีย์ (Zip Code)');", true);
                return;
            }

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาระบุเบอร์โทรศัพท์ (Telephone No.)');", true);
                return;
            }

            if (string.IsNullOrEmpty(txtRelationName1.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาระบุชื่อ-นามสกุลญาติคนที่ 1 (Name-Surname)');", true);
                return;
            }

            if (string.IsNullOrEmpty(txtRelation1.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาระบุความสัมพันธ์กับผู้ป่วยญาติคนที่ 1(Relationship)');", true);
                return;
            }

            if (string.IsNullOrEmpty(txtRelationName2.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาระบุความสัมพันธ์กับผู้ป่วยญาติคนที่ 2(Relationship)');", true);
                return;
            }

            if (string.IsNullOrEmpty(txtRelation2.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาระบุเบอร์โทรศัพท์ (Telephone No.)');", true);
                return;
            }

            if (string.IsNullOrEmpty(txtImportantDoc.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Script1", "openModalWaring('กรุณาเอกสารสำคัญ/ความต้องการสำคัญ');", true);
                return;
            }

            int success = 0;
            CustomerEntity customerEntity = new CustomerEntity();
            CustomerService customerService = new CustomerService();

            customerEntity = getDataFromUI();
            if (int.Parse(lblCustomerID.Text) > 0 )
            {
                success = customerService.InsertCustomer(customerEntity);
            }
            else
            {
                success = customerService.UpdateCustomer(customerEntity);
            }

            if (success > 0 )
            {
                Response.Redirect("/BackOffice/Customer/customer-list.aspx");
            }

        }

        protected void lbnPrint_Click(object sender, EventArgs e)
        {

        }


    }
}