using Definitions;
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

                        DBHelper.AddParam("Search", entity.firstname.Replace(" ",""));
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
            Customer_relativeEntity customer_RelativeEntity = new Customer_relativeEntity();
            Customer_service_agreementEntity customer_Service_AgreementEntity = new Customer_service_agreementEntity();

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
                        customer_RelativeEntity = DBHelper.SelectStoreProcedureFirst<Customer_relativeEntity>("select_customer_by_id");
                        customer_Service_AgreementEntity = DBHelper.SelectStoreProcedureFirst<Customer_service_agreementEntity>("select_customer_by_id");

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
                                DBHelper.AddParamOut("customer_relative_id", entity.customer_RelativeEntity.Customer_relative_id);
                                DBHelper.AddParam("customer_id", customer_id);
                                DBHelper.AddParam("customer_relative_name", entity.customer_RelativeEntity.Customer_relative_name);
                                DBHelper.AddParam("customer_relative_phone", entity.customer_RelativeEntity.Customer_relative_phone);
                                DBHelper.AddParam("customer_relation", entity.customer_RelativeEntity.Customer_relation);
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

                            if (entity.customer_RelativeEntity.Customer_relative_id > 0 )
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParam("customer_relative_id", entity.customer_RelativeEntity.Customer_relative_id);
                                DBHelper.AddParam("customer_id", entity.customer_id);
                                DBHelper.AddParam("customer_relative_name", entity.customer_RelativeEntity.Customer_relative_name);
                                DBHelper.AddParam("customer_relative_phone", entity.customer_RelativeEntity.Customer_relative_phone);
                                DBHelper.AddParam("customer_relation", entity.customer_RelativeEntity.Customer_relation);
                                DBHelper.ExecuteStoreProcedure("update_customer_relative");
                            }
                            else
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParamOut("customer_relative_id", entity.customer_RelativeEntity.Customer_relative_id);
                                DBHelper.AddParam("customer_id", entity.customer_id);
                                DBHelper.AddParam("customer_relative_name", entity.customer_RelativeEntity.Customer_relative_name);
                                DBHelper.AddParam("customer_relative_phone", entity.customer_RelativeEntity.Customer_relative_phone);
                                DBHelper.AddParam("customer_relation", entity.customer_RelativeEntity.Customer_relation);
                                DBHelper.ExecuteStoreProcedure("insert_customer_relative");
                            }

                            if (entity.customer_Service_AgreementEntity.Customer_service_agreement_id > 0 )
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
    }
}
