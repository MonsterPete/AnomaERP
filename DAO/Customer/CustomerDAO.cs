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
            throw new NotImplementedException();
        }

        public List<CustomerEntity> GetDataByCondition(CustomerEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public CustomerEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(CustomerEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(CustomerEntity entity)
        {
            throw new NotImplementedException();
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
