using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAO.Role;

namespace Service.Role
{
    public class PositionService : IServiceRepository<PositionEntity>
    {
        public List<PositionEntity> GetDataAll()
        {
            PositionDAO positionDAO = new PositionDAO();
            return positionDAO.GetDataAll();
        }

        public PositionEntity GetDataByID(long id)
        {
            PositionDAO positionDAO = new PositionDAO();
            return positionDAO.GetDataByID(id);
        }

        public List<PositionEntity> GetDataByCondition(PositionEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<PositionEntity> GetDataByCondition(PositionEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public int InsertData(PositionEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(PositionEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<PositionEntity> GetDataPositionGroupByID(int Group_id)
        {
            PositionDAO positionDAO = new PositionDAO();
            return positionDAO.GetDataPositionGroupByID(Group_id);
        }

        public int InsertDataMore(List<PositionEntity> positionEntities)
        {
            PositionDAO positionDAO = new PositionDAO();
            return positionDAO.InsertDataMore(positionEntities);
        }

    }
}
