using DAO;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class RedFlagService : IServiceRepository<RedFlagEntity>
    {
        public List<RedFlagEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<RedFlagEntity> GetDataByCondition(RedFlagEntity entity)
        {
            RedFlagDAO redFlagDAO = new RedFlagDAO();
            return redFlagDAO.GetDataByCondition(entity);
        }

        public List<RedFlagEntity> GetDataByCondition(RedFlagEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public RedFlagEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(RedFlagEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(RedFlagEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
