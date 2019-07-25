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

        public List<CustomerEntity> GetCustomerRegistationByCondition(CustomerEntity customerEntity)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            return customerDAO.GetCustomerRegistationByCondition(customerEntity);
        }

        public CustomerEntity GetCustomerRegistationByID(long id)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            return customerDAO.GetCustomerRegistationByID(id);
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
        
        public int InsertCustomerRegister(CustomerEntity customerEntity)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            return customerDAO.InsertCustomerRegister(customerEntity);
        }

        public int UpdateCustomerRegister(CustomerEntity customerEntity)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            return customerDAO.UpdateCustomerRegister(customerEntity);
        }

        public ProgressNoteEntity GetDataProgressNote(int visit_id)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            return customerDAO.GetDataProgressNote(visit_id);
        }

        public int UpdateProgressNote(ProgressNoteEntity progressNoteEntity)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            return customerDAO.UpdateProgressNote(progressNoteEntity);
        }

        public int InsertProgressNote(ProgressNoteEntity progressNoteEntity)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            return customerDAO.InsertProgressNote(progressNoteEntity);
        }

        public int UpdateCustomerStatus(CustomerEntity customerEntity)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            return customerDAO.UpdateCustomerStatus(customerEntity);
        }
    }
}
