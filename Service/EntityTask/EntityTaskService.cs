using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAO.EntityTask;


namespace Service.EntityTask
{
    public class EntityTaskService : IServiceRepository<EntityTaskEntity>
    {
        public List<EntityTaskEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<EntityTaskEntity> GetDataByCondition(EntityTaskEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<EntityTaskEntity> GetDataByCondition(EntityTaskEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public List<EntityTaskEntity> GetDataByEmployee(int employeeID)
        {
            EntityTaskDAO dao = new EntityTaskDAO();
            return dao.GetDataByEmployee(employeeID);
        }
        
        public EntityTaskEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(EntityTaskEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(EntityTaskEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
