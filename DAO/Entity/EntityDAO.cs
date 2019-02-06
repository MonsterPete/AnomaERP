using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace DAO.Entity
{
    class EntityDAO : IDAORepository<EntityEntity>
    {
        public List<EntityEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<EntityEntity> GetDataByCondition(EntityEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<EntityEntity> GetDataByCondition(EntityEntity entity, int Index)
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
