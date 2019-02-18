using DAO.Customer;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Customer
{
    public class CustomerService : IServiceRepository<CustomerEntity>
    {
        public List<CustomerEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<CustomerEntity> GetDataByCondition(CustomerEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<CustomerEntity> GetDataByCondition(CustomerEntity entity, int index)
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
            CustomerDAO customerDAO = new CustomerDAO();
            return customerDAO.GetDDLCustomerForAssginBed(branchId);
        }
    }
}
