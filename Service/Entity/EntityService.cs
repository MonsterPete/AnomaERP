using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAO.Entity;

namespace Service.Entity
{
    public class EntityService : IServiceRepository<EntityEntity>
    {
        public List<EntityEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<EntityEntity> GetDataByCondition(EntityEntity entity)
        {
            EntityDAO entityDAO = new EntityDAO();
            return entityDAO.GetDataByCondition(entity);
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
            EntityDAO entityDAO = new EntityDAO();
            return entityDAO.InsertData(entity);
        }

        public int UpdateData(EntityEntity entity)
        {
            EntityDAO entityDAO = new EntityDAO();
            return entityDAO.UpdateData(entity);
        }

        public EntityEntity GetDataEntityByID(int entity_id)
        {
            EntityDAO entityDAO = new EntityDAO();
            return entityDAO.GetDataEntityByID(entity_id);
        }
    }
}
