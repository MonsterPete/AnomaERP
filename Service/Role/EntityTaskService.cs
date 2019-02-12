using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAO.Role;

namespace Service.Role
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

        public EntityTaskEntity GetDataByID(long id)
        {
            EntityTaskDAO entityTaskDAO = new EntityTaskDAO();
            return entityTaskDAO.GetDataByID(id);
        }

        public List<EntityTaskEntity> GetDataByGroupID(int id)
        {
            EntityTaskDAO entityTaskDAO = new EntityTaskDAO();
            return entityTaskDAO.GetDataByGroupID(id);
        }

        public int InsertData(EntityTaskEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(EntityTaskEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<EntityTaskEntity> GetDataTaskByID(int Group_id)
        {
            EntityTaskDAO entityTaskDAO = new EntityTaskDAO();
            return entityTaskDAO.GetDataTaskByID(Group_id);
        }

        public int InsertDataMore(List<EntityTaskEntity> entityTaskEntities)
        {
            EntityTaskDAO entityTaskDAO = new EntityTaskDAO();
            return entityTaskDAO.InsertDataMore(entityTaskEntities);
        }

    }
}
