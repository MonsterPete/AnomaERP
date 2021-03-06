﻿using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO.Customer
{
    public class CustomerDAO : IDAORepository<CustomerEntity>
    {
        DBHelper DBHelper = null;

        public CustomerDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<CustomerEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<CustomerEntity> GetDataByCondition(CustomerEntity entity)
        {
            List<CustomerEntity> customerEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();

                        DBHelper.AddParam("Search", entity.firstname.Replace(" ", ""));
                        DBHelper.AddParam("branch_id", entity.branch_id);

                        customerEntities = DBHelper.SelectStoreProcedure<CustomerEntity>("select_customer_by_condition").ToList();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        DBHelper.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return customerEntities;
        }



        public List<CustomerEntity> GetDataByCondition(CustomerEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public CustomerEntity GetDataByID(long customer_id)
        {
            CustomerEntity customerEntity = new CustomerEntity();
            CustomerRelativeEntity customer_RelativeEntity = new CustomerRelativeEntity();
            CustomerServiceAgreementEntity customer_Service_AgreementEntity = new CustomerServiceAgreementEntity();

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("customer_id", customer_id);
                        customerEntity = DBHelper.SelectStoreProcedureFirst<CustomerEntity>("select_customer_by_id");
                        customer_RelativeEntity = DBHelper.SelectStoreProcedureFirst<CustomerRelativeEntity>("select_customer_by_id");
                        customer_Service_AgreementEntity = DBHelper.SelectStoreProcedureFirst<CustomerServiceAgreementEntity>("select_customer_by_id");

                        if (customer_RelativeEntity != null)
                        {
                            customerEntity.customer_RelativeEntity = customer_RelativeEntity;
                        }
                        else
                        {
                            customerEntity.customer_RelativeEntity = null;
                        }

                        if (customer_Service_AgreementEntity != null)
                        {
                            customerEntity.customer_Service_AgreementEntity = customer_Service_AgreementEntity;
                        }
                        else
                        {
                            customerEntity.customer_Service_AgreementEntity = null;
                        }

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        DBHelper.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return customerEntity;
        }

        public int InsertData(CustomerEntity entity)
        {
            Int32 customer_id = 0;
            int result = 0;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        using (DBHelper.BeginTransaction())
                        {
                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("customer_id", entity.customer_id);
                            DBHelper.AddParam("branch_id", entity.branch_id);
                            DBHelper.AddParam("contract_start", entity.contract_start);
                            DBHelper.AddParam("contract_end", entity.contract_end);
                            DBHelper.AddParam("firstname", entity.firstname);
                            DBHelper.AddParam("lastname", entity.lastname);
                            DBHelper.AddParam("gender", entity.gender);
                            DBHelper.AddParam("DOB", entity.DOB);
                            DBHelper.AddParam("create_by", entity.create_by);
                            DBHelper.AddParam("create_date", entity.create_date);
                            DBHelper.ExecuteStoreProcedure("insert_customer");
                            customer_id = DBHelper.GetParamOut<Int32>("customer_id");

                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("customer_relative_id", entity.customer_RelativeEntity.customer_relative_id);
                            DBHelper.AddParam("customer_id", customer_id);
                            DBHelper.AddParam("customer_relative_name", entity.customer_RelativeEntity.customer_relative_name_1);
                            DBHelper.AddParam("customer_relative_phone", entity.customer_RelativeEntity.customer_relative_phone_1);
                            DBHelper.AddParam("customer_relation", entity.customer_RelativeEntity.customer_relation_1);
                            DBHelper.ExecuteStoreProcedure("insert_customer_relative");


                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("customer_service_agreement_id", entity.customer_Service_AgreementEntity.Customer_service_agreement_id);
                            DBHelper.AddParam("customer_id", customer_id);
                            DBHelper.AddParam("month_service_cost", entity.customer_Service_AgreementEntity.Month_service_cost);
                            DBHelper.AddParam("diaper_commutation_cost", entity.customer_Service_AgreementEntity.Diaper_commutation_cost);
                            DBHelper.AddParam("dressing_equipment_commutation_cost", entity.customer_Service_AgreementEntity.Dressing_equipment_commutation_cost);
                            DBHelper.AddParam("customer_Reservations_cost", entity.customer_Service_AgreementEntity.Customer_reservations_cost);
                            DBHelper.AddParam("customer_balance_cost", entity.customer_Service_AgreementEntity.Customer_balance_cost);
                            DBHelper.AddParam("create_date", entity.customer_Service_AgreementEntity.Create_date);
                            DBHelper.AddParam("remark", entity.customer_Service_AgreementEntity.Remark);
                            DBHelper.ExecuteStoreProcedure("insert_customer_service_agreement");

                            //Insert day activities from contract date length
                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("day_activities_id", 0);
                            DBHelper.AddParam("customer_id", customer_id);
                            DBHelper.AddParam("contract_start", entity.contract_start);
                            DBHelper.AddParam("contract_end", entity.contract_end);
                            DBHelper.ExecuteStoreProcedure("insert_day_activities");

                            DBHelper.CommitTransaction();
                            result = customer_id;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        DBHelper.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int UpdateData(CustomerEntity entity)
        {
            int result = 0;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        using (DBHelper.BeginTransaction())
                        {
                            DBHelper.CreateParameters();
                            DBHelper.AddParam("customer_id", entity.customer_id);
                            DBHelper.AddParam("branch_id", entity.branch_id);
                            DBHelper.AddParam("contract_start", entity.contract_start);
                            DBHelper.AddParam("contract_end", entity.contract_end);
                            DBHelper.AddParam("firstname", entity.firstname);
                            DBHelper.AddParam("lastname", entity.lastname);
                            DBHelper.AddParam("gender", entity.gender);
                            DBHelper.AddParam("DOB", entity.DOB);
                            DBHelper.AddParam("modify_by", entity.modify_by);
                            DBHelper.AddParam("modify_date", entity.modify_date);
                            DBHelper.AddParamOut("success_row", result);
                            DBHelper.ExecuteStoreProcedure("update_customer");
                            result = DBHelper.GetParamOut<Int32>("success_row");

                            if (entity.customer_RelativeEntity.customer_relative_id > 0)
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParam("customer_relative_id", entity.customer_RelativeEntity.customer_relative_id);
                                DBHelper.AddParam("customer_id", entity.customer_id);
                                DBHelper.AddParam("customer_relative_name", entity.customer_RelativeEntity.customer_relative_name_1);
                                DBHelper.AddParam("customer_relative_phone", entity.customer_RelativeEntity.customer_relative_phone_1);
                                DBHelper.AddParam("customer_relation", entity.customer_RelativeEntity.customer_relation_1);
                                DBHelper.ExecuteStoreProcedure("update_customer_relative");
                            }
                            else
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParamOut("customer_relative_id", entity.customer_RelativeEntity.customer_relative_id);
                                DBHelper.AddParam("customer_id", entity.customer_id);
                                DBHelper.AddParam("customer_relative_name", entity.customer_RelativeEntity.customer_relative_name_1);
                                DBHelper.AddParam("customer_relative_phone", entity.customer_RelativeEntity.customer_relative_phone_1);
                                DBHelper.AddParam("customer_relation", entity.customer_RelativeEntity.customer_relation_1);
                                DBHelper.ExecuteStoreProcedure("insert_customer_relative");
                            }

                            if (entity.customer_Service_AgreementEntity.Customer_service_agreement_id > 0)
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParam("customer_service_agreement_id", entity.customer_Service_AgreementEntity.Customer_service_agreement_id);
                                DBHelper.AddParam("customer_id", entity.customer_id);
                                DBHelper.AddParam("month_service_cost", entity.customer_Service_AgreementEntity.Month_service_cost);
                                DBHelper.AddParam("diaper_commutation_cost", entity.customer_Service_AgreementEntity.Diaper_commutation_cost);
                                DBHelper.AddParam("dressing_equipment_commutation_cost", entity.customer_Service_AgreementEntity.Dressing_equipment_commutation_cost);
                                DBHelper.AddParam("customer_Reservations_cost", entity.customer_Service_AgreementEntity.Customer_reservations_cost);
                                DBHelper.AddParam("customer_balance_cost", entity.customer_Service_AgreementEntity.Customer_balance_cost);
                                DBHelper.AddParam("create_date", entity.customer_Service_AgreementEntity.Create_date);
                                DBHelper.AddParam("remark", entity.customer_Service_AgreementEntity.Remark);
                                DBHelper.ExecuteStoreProcedure("update_customer_service_agreement");
                            }
                            else
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParamOut("customer_service_agreement_id", entity.customer_Service_AgreementEntity.Customer_service_agreement_id);
                                DBHelper.AddParam("customer_id", entity.customer_id);
                                DBHelper.AddParam("month_service_cost", entity.customer_Service_AgreementEntity.Month_service_cost);
                                DBHelper.AddParam("diaper_commutation_cost", entity.customer_Service_AgreementEntity.Diaper_commutation_cost);
                                DBHelper.AddParam("dressing_equipment_commutation_cost", entity.customer_Service_AgreementEntity.Dressing_equipment_commutation_cost);
                                DBHelper.AddParam("customer_Reservations_cost", entity.customer_Service_AgreementEntity.Customer_reservations_cost);
                                DBHelper.AddParam("customer_balance_cost", entity.customer_Service_AgreementEntity.Customer_balance_cost);
                                DBHelper.AddParam("create_date", entity.customer_Service_AgreementEntity.Create_date);
                                DBHelper.AddParam("remark", entity.customer_Service_AgreementEntity.Remark);
                                DBHelper.ExecuteStoreProcedure("insert_customer_service_agreement");
                            }

                            DBHelper.CommitTransaction();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        DBHelper.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<CustomerEntity> GetDDLCustomerForAssginBed(int branchId)
        {
            List<CustomerEntity> customerEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();

                        DBHelper.AddParam("branch_id", branchId);


                        customerEntities = DBHelper.SelectStoreProcedure<CustomerEntity>("ddl_customer_for_assginbed_bed").ToList();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        DBHelper.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return customerEntities;
        }

        public CustomerEntity GetCustomerRegistationByID(long customer_id)
        {
            CustomerEntity customerEntity = new CustomerEntity();
            Customer_information_recieveEntity customer_Information_RecieveEntity = new Customer_information_recieveEntity();
            CustomerRelativeEntity customer_RelativeEntity = new CustomerRelativeEntity();
            Customer_vital_signEntity customer_Vital_SignEntity = new Customer_vital_signEntity();

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("customer_id", customer_id);
                        customerEntity = DBHelper.SelectStoreProcedureFirst<CustomerEntity>("select_customer_by_id");
                        customer_Information_RecieveEntity = DBHelper.SelectStoreProcedureFirst<Customer_information_recieveEntity>("select_customer_information_recieve_by_customer_id");
                        customer_RelativeEntity = DBHelper.SelectStoreProcedureFirst<CustomerRelativeEntity>("select_customer_relative_by_customer_id");
                        customer_Vital_SignEntity = DBHelper.SelectStoreProcedureFirst<Customer_vital_signEntity>("select_customer_vital_sign_by_customer_id");

                        if (customer_Information_RecieveEntity != null)
                        {
                            customerEntity.customer_Information_RecieveEntity = customer_Information_RecieveEntity;
                        }
                        else
                        {
                            customerEntity.customer_Information_RecieveEntity = null;
                        }

                        if (customer_RelativeEntity != null)
                        {
                            customerEntity.customer_RelativeEntity = customer_RelativeEntity;
                        }
                        else
                        {
                            customerEntity.customer_RelativeEntity = null;
                        }

                        if (customer_Vital_SignEntity != null)
                        {
                            customerEntity.customer_Vital_SignEntity = customer_Vital_SignEntity;
                        }
                        else
                        {
                            customerEntity.customer_Vital_SignEntity = null;
                        }

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        DBHelper.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return customerEntity;
        }

        public int InsertCustomerRegister(CustomerEntity entity)
        {
            Int32 customer_id = 0;
            int result = 0;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        using (DBHelper.BeginTransaction())
                        {
                            #region Customer
                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("customer_id", entity.customer_id);
                            DBHelper.AddParam("branch_id", entity.branch_id);
                            DBHelper.AddParam("HN_no", null);
                            DBHelper.AddParam("firstname", entity.firstname);
                            DBHelper.AddParam("lastname", entity.lastname);
                            DBHelper.AddParam("id_card", entity.id_card);
                            DBHelper.AddParam("general_information_upload", entity.general_information_upload);
                            DBHelper.AddParam("DOB", entity.DOB);
                            DBHelper.AddParam("age", entity.age);
                            DBHelper.AddParam("gender", entity.gender);
                            DBHelper.AddParam("martial_status", entity.martial_status);
                            DBHelper.AddParam("address", entity.address);
                            DBHelper.AddParam("sub_district", entity.sub_district);
                            DBHelper.AddParam("district", entity.district);
                            DBHelper.AddParam("province", entity.province);
                            DBHelper.AddParam("zipcode", entity.zipcode);
                            DBHelper.AddParam("tel", entity.tel);
                            DBHelper.AddParam("information_channel", entity.information_channel);
                            DBHelper.AddParam("information_channel_comment", entity.information_channel_comment);
                            DBHelper.AddParam("current_illness", entity.current_illness);
                            DBHelper.AddParam("current_illness_history", entity.current_illness_history);
                            DBHelper.AddParam("doctor_diagnosis", entity.doctor_diagnosis);
                            DBHelper.AddParam("treatment_has_received", entity.treatment_has_received);
                            DBHelper.AddParam("is_surgery", entity.is_surgery);
                            DBHelper.AddParam("surgery_comment", entity.surgery_comment);
                            DBHelper.AddParam("contract_end", null);
                            DBHelper.AddParam("is_have_bed", entity.is_have_bed);
                            DBHelper.AddParam("is_admit", entity.is_admit);
                            DBHelper.AddParam("is_delete", entity.is_delete);
                            DBHelper.AddParam("is_active", entity.is_active);
                            DBHelper.AddParam("create_date", entity.create_date);
                            DBHelper.AddParam("create_by", entity.create_by);

                            DBHelper.ExecuteStoreProcedure("insert_customer");
                            customer_id = DBHelper.GetParamOut<Int32>("customer_id");

                            #endregion

                            #region Customer RelativeEntity
                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("customer_relative_id", entity.customer_RelativeEntity.customer_relative_id);
                            DBHelper.AddParam("customer_id", customer_id);
                            DBHelper.AddParam("customer_relative_name_1",
                                entity.customer_RelativeEntity.customer_relative_name_1);
                            DBHelper.AddParam("customer_relative_phone_1",
                                entity.customer_RelativeEntity.customer_relative_phone_1);
                            DBHelper.AddParam("customer_relative_emergency_tel_1",
                                entity.customer_RelativeEntity.customer_relative_emergency_tel_1);
                            DBHelper.AddParam("customer_relation_line_id_1",
                                entity.customer_RelativeEntity.customer_relation_line_id_1);
                            DBHelper.AddParam("customer_relation_facebook_1",
                                entity.customer_RelativeEntity.customer_relation_facebook_1);
                            DBHelper.AddParam("customer_relation_email_1",
                                entity.customer_RelativeEntity.customer_relation_email_1);
                            DBHelper.AddParam("customer_relation_address_1",
                                entity.customer_RelativeEntity.customer_relation_address_1);
                            DBHelper.AddParam("customer_relation_1",
                                entity.customer_RelativeEntity.customer_relation_1);
                            DBHelper.AddParam("customer_relative_name_2",
                                entity.customer_RelativeEntity.customer_relative_name_2);
                            DBHelper.AddParam("customer_relative_phone_2",
                                entity.customer_RelativeEntity.customer_relative_phone_2);
                            DBHelper.AddParam("customer_relative_emergency_tel_2",
                                entity.customer_RelativeEntity.customer_relative_emergency_tel_2);
                            DBHelper.AddParam("customer_relation_line_id_2",
                                entity.customer_RelativeEntity.customer_relation_line_id_2);
                            DBHelper.AddParam("customer_relation_facebook_2",
                                entity.customer_RelativeEntity.customer_relation_facebook_2);
                            DBHelper.AddParam("customer_relation_email_2",
                                entity.customer_RelativeEntity.customer_relation_email_2);
                            DBHelper.AddParam("customer_relation_address_2",
                                entity.customer_RelativeEntity.customer_relation_address_2);
                            DBHelper.AddParam("customer_relation_2",
                                entity.customer_RelativeEntity.customer_relation_2);

                            DBHelper.ExecuteStoreProcedure("insert_customer_relative");

                            #endregion

                            #region Customer Vital Sign

                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("customer_vital_sign_id", 0);
                            DBHelper.AddParam("customer_id", customer_id);
                            DBHelper.AddParam("t_c", entity.customer_Vital_SignEntity.t_c);
                            DBHelper.AddParam("p_min", entity.customer_Vital_SignEntity.p_min);
                            DBHelper.AddParam("r_min", entity.customer_Vital_SignEntity.r_min);
                            DBHelper.AddParam("bp_mmhg", entity.customer_Vital_SignEntity.bp_mmhg);
                            DBHelper.AddParam("o2sat_percent", entity.customer_Vital_SignEntity.o2sat_percent);
                            DBHelper.AddParam("bw_kg", entity.customer_Vital_SignEntity.bw_kg);
                            DBHelper.AddParam("ht_cm", entity.customer_Vital_SignEntity.ht_cm);
                            DBHelper.AddParam("bm_index", entity.customer_Vital_SignEntity.bm_index);
                            DBHelper.ExecuteStoreProcedure("insert_customer_vital_sign");

                            #endregion

                            #region Customer Information Recieve

                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("customer_information_recieve_id", 0);
                            DBHelper.AddParam("customer_id", customer_id);
                            DBHelper.AddParam("customer_information_recieve_date", null);
                            DBHelper.AddParam("customer_information_recieve_service_by",
                                entity.customer_Information_RecieveEntity.customer_information_recieve_service_by);
                            DBHelper.AddParam("other",
                                entity.customer_Information_RecieveEntity.other);
                            DBHelper.AddParam("important_documents",
                                entity.customer_Information_RecieveEntity.important_documents);

                            DBHelper.ExecuteStoreProcedure("insert_customer_information_recieve");

                            #endregion

                            if (entity.customerCongenitalDiseaseEntities.Count > 0)
                            {
                                foreach (CustomerCongenitalDiseaseEntity index in entity.customerCongenitalDiseaseEntities)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParamOut("customer_congenital_disease_id", 0);
                                    DBHelper.AddParam("customer_id", customer_id);
                                    DBHelper.AddParam("congenital_disease_id",
                                        index.congenital_disease_id);
                                    DBHelper.AddParam("create_date",
                                        index.created_date);
                                    DBHelper.AddParam("create_by",
                                        index.created_by);
                                    DBHelper.AddParam("is_active",
                                        true);
                                    DBHelper.AddParam("is_delete",
                                        false);

                                    DBHelper.ExecuteStoreProcedure("insert_customer_congenital_disease");
                                }
                            }

                            if (entity.customerPersonalFactorsEntities.Count > 0)
                            {
                                foreach (CustomerPersonalFactorsEntity index in entity.customerPersonalFactorsEntities)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParamOut("customer_personal_factors_id", 0);
                                    DBHelper.AddParam("customer_id", customer_id);
                                    DBHelper.AddParam("personal_factors_id",
                                        index.personal_factors_id);
                                    DBHelper.AddParam("created_date",
                                        index.created_date);
                                    DBHelper.AddParam("created_by",
                                        index.created_by);
                                    DBHelper.AddParam("is_active",
                                        true);
                                    DBHelper.AddParam("is_delete",
                                        false);

                                    DBHelper.ExecuteStoreProcedure("insert_customer_personal_factors");
                                }
                            }

                            if (entity.customerRedFlagEntities.Count > 0)
                            {
                                foreach (CustomerRedFlagEntity index in entity.customerRedFlagEntities)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParamOut("customer_red_flag_id", 0);
                                    DBHelper.AddParam("customer_id", customer_id);
                                    DBHelper.AddParam("red_flag_id",
                                        index.red_flag_id);
                                    DBHelper.AddParam("created_date",
                                        index.created_date);
                                    DBHelper.AddParam("created_by",
                                        index.created_by);
                                    DBHelper.AddParam("is_active",
                                        true);
                                    DBHelper.AddParam("is_delete",
                                        false);

                                    DBHelper.ExecuteStoreProcedure("insert_customer_red_flag");
                                }
                            }

                            if (entity.customerRiskAssessmentEntities.Count > 0)
                            {
                                foreach (CustomerRiskAssessmentEntity index in entity.customerRiskAssessmentEntities)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParamOut("customer_risk_assessment_id", 0);
                                    DBHelper.AddParam("customer_id", customer_id);
                                    DBHelper.AddParam("risk_assessment_id",
                                        index.risk_assessment_id);
                                    DBHelper.AddParam("created_date",
                                        index.created_date);
                                    DBHelper.AddParam("created_by",
                                        index.created_by);
                                    DBHelper.AddParam("is_active",
                                        true);
                                    DBHelper.AddParam("is_delete",
                                        false);

                                    DBHelper.ExecuteStoreProcedure("insert_customer_risk_assessment");
                                }
                            }

                            DBHelper.CommitTransaction();
                            result = customer_id;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        DBHelper.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int UpdateCustomerRegister(CustomerEntity entity)
        {
            int result = 0;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        using (DBHelper.BeginTransaction())
                        {
                            #region Customer
                            DBHelper.CreateParameters();
                            DBHelper.AddParam("customer_id", entity.customer_id);
                            DBHelper.AddParam("branch_id", entity.branch_id);
                            DBHelper.AddParam("HN_no", null);
                            DBHelper.AddParam("firstname", entity.firstname);
                            DBHelper.AddParam("lastname", entity.lastname);
                            DBHelper.AddParam("id_card", entity.id_card);
                            DBHelper.AddParam("general_information_upload", entity.general_information_upload);
                            DBHelper.AddParam("DOB", entity.DOB);
                            DBHelper.AddParam("age", entity.age);
                            DBHelper.AddParam("gender", entity.gender);
                            DBHelper.AddParam("martial_status", entity.martial_status);
                            DBHelper.AddParam("address", entity.address);
                            DBHelper.AddParam("sub_district", entity.sub_district);
                            DBHelper.AddParam("district", entity.district);
                            DBHelper.AddParam("province", entity.province);
                            DBHelper.AddParam("zipcode", entity.zipcode);
                            DBHelper.AddParam("tel", entity.tel);
                            DBHelper.AddParam("information_channel", entity.information_channel);
                            DBHelper.AddParam("information_channel_comment", entity.information_channel_comment);
                            DBHelper.AddParam("current_illness", entity.current_illness);
                            DBHelper.AddParam("current_illness_history", entity.current_illness_history);
                            DBHelper.AddParam("doctor_diagnosis", entity.doctor_diagnosis);
                            DBHelper.AddParam("treatment_has_received", entity.treatment_has_received);
                            DBHelper.AddParam("is_surgery", entity.is_surgery);
                            DBHelper.AddParam("surgery_comment", entity.surgery_comment);
                            DBHelper.AddParam("contract_end", null);
                            DBHelper.AddParam("is_have_bed", entity.is_have_bed);
                            DBHelper.AddParam("is_admit", entity.is_admit);
                            DBHelper.AddParam("is_delete", entity.is_delete);
                            DBHelper.AddParam("is_active", entity.is_active);
                            DBHelper.AddParam("modify_date", entity.modify_date);
                            DBHelper.AddParam("modify_by", entity.modify_by);
                            DBHelper.AddParamOut("success_row", result);

                            DBHelper.ExecuteStoreProcedure("update_customer");
                            result = DBHelper.GetParamOut<Int32>("success_row");

                            #endregion

                            #region Customer RelativeEntity
                            DBHelper.CreateParameters();
                            DBHelper.AddParam("customer_relative_id", entity.customer_RelativeEntity.customer_relative_id);
                            DBHelper.AddParam("customer_id", entity.customer_id);
                            DBHelper.AddParam("customer_relative_name_1",
                                entity.customer_RelativeEntity.customer_relative_name_1);
                            DBHelper.AddParam("customer_relative_phone_1",
                                entity.customer_RelativeEntity.customer_relative_phone_1);
                            DBHelper.AddParam("customer_relative_emergency_tel_1",
                                entity.customer_RelativeEntity.customer_relative_emergency_tel_1);
                            DBHelper.AddParam("customer_relation_line_id_1",
                                entity.customer_RelativeEntity.customer_relation_line_id_1);
                            DBHelper.AddParam("customer_relation_facebook_1",
                                entity.customer_RelativeEntity.customer_relation_facebook_1);
                            DBHelper.AddParam("customer_relation_email_1",
                                entity.customer_RelativeEntity.customer_relation_email_1);
                            DBHelper.AddParam("customer_relation_address_1",
                                entity.customer_RelativeEntity.customer_relation_address_1);
                            DBHelper.AddParam("customer_relation_1",
                                entity.customer_RelativeEntity.customer_relation_1);
                            DBHelper.AddParam("customer_relative_name_2",
                                entity.customer_RelativeEntity.customer_relative_name_2);
                            DBHelper.AddParam("customer_relative_phone_2",
                                entity.customer_RelativeEntity.customer_relative_phone_2);
                            DBHelper.AddParam("customer_relative_emergency_tel_2",
                                entity.customer_RelativeEntity.customer_relative_emergency_tel_2);
                            DBHelper.AddParam("customer_relation_line_id_2",
                                entity.customer_RelativeEntity.customer_relation_line_id_2);
                            DBHelper.AddParam("customer_relation_facebook_2",
                                entity.customer_RelativeEntity.customer_relation_facebook_2);
                            DBHelper.AddParam("customer_relation_email_2",
                                entity.customer_RelativeEntity.customer_relation_email_2);
                            DBHelper.AddParam("customer_relation_address_2",
                                entity.customer_RelativeEntity.customer_relation_address_2);
                            DBHelper.AddParam("customer_relation_2",
                                entity.customer_RelativeEntity.customer_relation_2);

                            DBHelper.ExecuteStoreProcedure("update_customer_relative");

                            #endregion

                            #region Customer Vital Sign

                            DBHelper.CreateParameters();
                            DBHelper.AddParam("customer_vital_sign_id", entity.customer_Vital_SignEntity.customer_vital_sign_id);
                            DBHelper.AddParam("customer_id", entity.customer_id);
                            DBHelper.AddParam("t_c", entity.customer_Vital_SignEntity.t_c);
                            DBHelper.AddParam("p_min", entity.customer_Vital_SignEntity.p_min);
                            DBHelper.AddParam("r_min", entity.customer_Vital_SignEntity.r_min);
                            DBHelper.AddParam("bp_mmhg", entity.customer_Vital_SignEntity.bp_mmhg);
                            DBHelper.AddParam("o2sat_percent", entity.customer_Vital_SignEntity.o2sat_percent);
                            DBHelper.AddParam("bw_kg", entity.customer_Vital_SignEntity.bw_kg);
                            DBHelper.AddParam("ht_cm", entity.customer_Vital_SignEntity.ht_cm);
                            DBHelper.AddParam("bm_index", entity.customer_Vital_SignEntity.bm_index);
                            DBHelper.ExecuteStoreProcedure("update_customer_vital_sign");

                            #endregion

                            #region Customer Information Recieve

                            DBHelper.CreateParameters();
                            DBHelper.AddParam("customer_information_recieve_id", entity.customer_Information_RecieveEntity.customer_information_recieve_id);
                            DBHelper.AddParam("customer_id", entity.customer_id);
                            DBHelper.AddParam("customer_information_recieve_date", null);
                            DBHelper.AddParam("customer_information_recieve_service_by",
                                entity.customer_Information_RecieveEntity.customer_information_recieve_service_by);
                            DBHelper.AddParam("other",
                                entity.customer_Information_RecieveEntity.other);
                            DBHelper.AddParam("important_documents",
                                entity.customer_Information_RecieveEntity.important_documents);

                            DBHelper.ExecuteStoreProcedure("update_customer_information_recieve");

                            #endregion

                            if (entity.customerCongenitalDiseaseEntities.Count > 0)
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParam("customer_id", entity.customer_id);
                                DBHelper.ExecuteStoreProcedure("delete_customer_congenital_disease");

                                foreach (CustomerCongenitalDiseaseEntity index in entity.customerCongenitalDiseaseEntities)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParamOut("customer_congenital_disease_id", 0);
                                    DBHelper.AddParam("customer_id", entity.customer_id);
                                    DBHelper.AddParam("congenital_disease_id",
                                        index.congenital_disease_id);
                                    DBHelper.AddParam("create_date",
                                        index.created_date);
                                    DBHelper.AddParam("create_by",
                                        index.created_by);
                                    DBHelper.AddParam("is_active",
                                        true);
                                    DBHelper.AddParam("is_delete",
                                        false);

                                    DBHelper.ExecuteStoreProcedure("insert_customer_congenital_disease");
                                }
                            }

                            if (entity.customerPersonalFactorsEntities.Count > 0)
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParam("customer_id", entity.customer_id);
                                DBHelper.ExecuteStoreProcedure("delete_customer_personal_factors");

                                foreach (CustomerPersonalFactorsEntity index in entity.customerPersonalFactorsEntities)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParamOut("customer_personal_factors_id", 0);
                                    DBHelper.AddParam("customer_id", entity.customer_id);
                                    DBHelper.AddParam("personal_factors_id",
                                        index.personal_factors_id);
                                    DBHelper.AddParam("created_date",
                                        index.created_date);
                                    DBHelper.AddParam("created_by",
                                        index.created_by);
                                    DBHelper.AddParam("is_active",
                                        true);
                                    DBHelper.AddParam("is_delete",
                                        false);

                                    DBHelper.ExecuteStoreProcedure("insert_customer_personal_factors");
                                }
                            }

                            if (entity.customerRedFlagEntities.Count > 0)
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParam("customer_id", entity.customer_id);
                                DBHelper.ExecuteStoreProcedure("delete_customer_red_flag");

                                foreach (CustomerRedFlagEntity index in entity.customerRedFlagEntities)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParamOut("customer_red_flag_id", 0);
                                    DBHelper.AddParam("customer_id", entity.customer_id);
                                    DBHelper.AddParam("red_flag_id",
                                        index.red_flag_id);
                                    DBHelper.AddParam("created_date",
                                        index.created_date);
                                    DBHelper.AddParam("created_by",
                                        index.created_by);
                                    DBHelper.AddParam("is_active",
                                        true);
                                    DBHelper.AddParam("is_delete",
                                        false);

                                    DBHelper.ExecuteStoreProcedure("insert_customer_red_flag");
                                }
                            }

                            if (entity.customerRiskAssessmentEntities.Count > 0)
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParam("customer_id", entity.customer_id);
                                DBHelper.ExecuteStoreProcedure("delete_customer_risk_assessment");

                                foreach (CustomerRiskAssessmentEntity index in entity.customerRiskAssessmentEntities)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParamOut("customer_risk_assessment_id", 0);
                                    DBHelper.AddParam("customer_id", entity.customer_id);
                                    DBHelper.AddParam("risk_assessment_id",
                                        index.risk_assessment_id);
                                    DBHelper.AddParam("created_date",
                                        index.created_date);
                                    DBHelper.AddParam("created_by",
                                        index.created_by);
                                    DBHelper.AddParam("is_active",
                                        true);
                                    DBHelper.AddParam("is_delete",
                                        false);

                                    DBHelper.ExecuteStoreProcedure("insert_customer_risk_assessment");
                                }
                            }

                            DBHelper.CommitTransaction();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        DBHelper.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<CustomerEntity> GetCustomerRegistationByCondition(CustomerEntity entity)
        {
            List<CustomerEntity> customerEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("Search", entity.firstname.Replace(" ", ""));
                        DBHelper.AddParam("branch_id", entity.branch_id);
                        DBHelper.AddParam("is_active", entity.is_active);

                        customerEntities = DBHelper.SelectStoreProcedure<CustomerEntity>("select_customer_registation__by_condition").ToList();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        DBHelper.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return customerEntities;
        }

        public ProgressNoteEntity GetDataProgressNote(int visit_id)
        {
            ProgressNoteEntity customer_Vital_SignEntity = new ProgressNoteEntity();

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("visit_id", visit_id);

                        customer_Vital_SignEntity = DBHelper.SelectStoreProcedureFirst<ProgressNoteEntity>("select_customer_progress_note_by_visit_id");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        DBHelper.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return customer_Vital_SignEntity;
        }

        public int InsertProgressNote(ProgressNoteEntity progressNoteEntity)
        {
            int result = 0;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        using (DBHelper.BeginTransaction())
                        {

                            #region Customer Vital Sign

                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("progress_note_id", progressNoteEntity.progress_note_id);
                            DBHelper.AddParam("visit_id", progressNoteEntity.visit_id);
                            DBHelper.AddParam("t_c", progressNoteEntity.t_c);
                            DBHelper.AddParam("p_min", progressNoteEntity.p_min);
                            DBHelper.AddParam("r_min", progressNoteEntity.r_min);
                            DBHelper.AddParam("bp_mmhg", progressNoteEntity.bp_mmhg);
                            DBHelper.AddParam("o2sat_percent", progressNoteEntity.o2sat_percent);
                            DBHelper.AddParam("bw_kg", progressNoteEntity.bw_kg);
                            DBHelper.AddParam("ht_cm", progressNoteEntity.ht_cm);
                            DBHelper.AddParam("bm_index", progressNoteEntity.bm_index);
                            DBHelper.AddParam("description", progressNoteEntity.Description);
                            DBHelper.ExecuteStoreProcedure("insert_visit_customer_progress_note");
                            result = DBHelper.GetParamOut<Int32>("progress_note_id");

                            #endregion

                            DBHelper.CommitTransaction();
  
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        DBHelper.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int UpdateProgressNote(ProgressNoteEntity progressNoteEntity)
        {
            int result = 0;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        using (DBHelper.BeginTransaction())
                        {

                            #region Customer Vital Sign

                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("success_row", result);
                            DBHelper.AddParam("progress_note_id", progressNoteEntity.progress_note_id);
                            DBHelper.AddParam("visit_id", progressNoteEntity.visit_id);
                            DBHelper.AddParam("t_c", progressNoteEntity.t_c);
                            DBHelper.AddParam("p_min", progressNoteEntity.p_min);
                            DBHelper.AddParam("r_min", progressNoteEntity.r_min);
                            DBHelper.AddParam("bp_mmhg", progressNoteEntity.bp_mmhg);
                            DBHelper.AddParam("o2sat_percent", progressNoteEntity.o2sat_percent);
                            DBHelper.AddParam("bw_kg", progressNoteEntity.bw_kg);
                            DBHelper.AddParam("ht_cm", progressNoteEntity.ht_cm);
                            DBHelper.AddParam("bm_index", progressNoteEntity.bm_index);
                            DBHelper.AddParam("description", progressNoteEntity.Description);
                            DBHelper.ExecuteStoreProcedure("update_visit_customer_progress_note");
                            result = DBHelper.GetParamOut<Int32>("success_row");

                            #endregion

                            DBHelper.CommitTransaction(); 
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        DBHelper.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        public int UpdateCustomerStatus(CustomerEntity customerEntity)
        {
            int result = 0;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        using (DBHelper.BeginTransaction())
                        {
                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("success_row", result);
                            DBHelper.AddParam("customer_id", customerEntity.customer_id);
                            DBHelper.AddParam("is_active", customerEntity.is_active);
                            DBHelper.ExecuteStoreProcedure("update_customer_status");
                            result = DBHelper.GetParamOut<Int32>("success_row");

                            DBHelper.CommitTransaction();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        DBHelper.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
