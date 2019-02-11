using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAO.Role;

namespace Service.Role
{
    public class PositionGroupService : IServiceRepository<PositionGroupEntity>
    {
        public List<PositionGroupEntity> GetDataAll()
        {
            PositionGroupDAO positionGroupDAO = new PositionGroupDAO();
            return positionGroupDAO.GetDataAll();
        }

        public List<PositionGroupEntity> GetDataByCondition(PositionGroupEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<PositionGroupEntity> GetDataByCondition(PositionGroupEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public PositionGroupEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(PositionGroupEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(PositionGroupEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
