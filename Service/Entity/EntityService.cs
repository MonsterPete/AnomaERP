using System;
using System.Collections.Generic;
using System.Text;
using Entity;

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
            throw new NotImplementedException();
        }

        public int UpdateData(EntityEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
