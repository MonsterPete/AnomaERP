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
            CustomerDAO customerDAO = new CustomerDAO();
            return customerDAO.GetDataByCondition(entity);
        }

        public List<CustomerEntity> GetDataByCondition(CustomerEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public CustomerEntity GetDataByID(long id)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            return customerDAO.GetDataByID(id);
        }

        public int InsertData(CustomerEntity entity)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            return customerDAO.InsertData(entity);
        }

        public int UpdateData(CustomerEntity entity)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            return customerDAO.UpdateData(entity);
        }

        public List<CustomerEntity> GetDDLCustomerForAssginBed(int branchId)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            return customerDAO.GetDDLCustomerForAssginBed(branchId);
        }
        
        public Boolean InsertDataCustomer(CustomerEntity customerEntity)
        {
            return true;
        }
    }
}
