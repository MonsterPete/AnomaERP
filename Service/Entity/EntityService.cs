using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAO.Entity;

namespace Service.Entity
{
    public class EntityService : IServiceRepository<EntityEntity>
    {
        EntityDAO entityDAO = new EntityDAO();

        public List<EntityEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<EntityEntity> GetDataByCondition(EntityEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<EntityEntity> GetDataByCondition(EntityEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public EntityEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(EntityEntity entity)
        {
            return entityDAO.InsertData(entity);
        }

        public int UpdateData(EntityEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
