using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAO.Employee;

namespace Service.Employee
{
    public class EmployeeService : IServiceRepository<EmployeeEntity>
    {
        public List<EmployeeEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<EmployeeEntity> GetDataByCondition(EmployeeEntity entity)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            return employeeDAO.GetDataByCondition(entity);
        }

        public List<EmployeeEntity> GetDataByCondition(EmployeeEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public EmployeeEntity GetDataByID(long id)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            return employeeDAO.GetDataByID(id);
        }

        public int InsertData(EmployeeEntity entity)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            return employeeDAO.InsertData(entity);
        }

        public int UpdateData(EmployeeEntity entity)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            return employeeDAO.UpdateData(entity);
        }

        public int UpdateStatusData(EmployeeEntity entity)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            return employeeDAO.UpdateStatusData(entity);
        }
    }   
}
