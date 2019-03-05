using Entity;
using System;
using System.Collections.Generic;
using System.Text;
using DAO.Branch.BranchBuilding;

namespace Service.Branch.BranchBuilding
{
    public class BranchBedService : IServiceRepository<BranchBedEntity>
    {
        public List<BranchBedEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<BranchBedEntity> GetDataByCondition(BranchBedEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<BranchBedEntity> GetDataByCondition(BranchBedEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public BranchBedEntity GetDataByID(long id)
        {
            BranchBedDAO branchBedDAO = new BranchBedDAO();
            return branchBedDAO.GetDataByID(id);
        }

        public int InsertData(BranchBedEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(BranchBedEntity entity)
        {
            BranchBedDAO branchBedDAO = new BranchBedDAO();
            return branchBedDAO.UpdateData(entity);
        }

        public NameEntity GetNameFloorAndRoom(int roomId)
        {
            BranchBedDAO branchBedDAO = new BranchBedDAO();
            return branchBedDAO.GetNameFloorAndRoom(roomId);
        }

        public List<BranchBedEntity> GetDataBranchBedByID(int room_id)
        {
            BranchBedDAO branchBedDAO = new BranchBedDAO();
            return branchBedDAO.GetDataBranchBedByID(room_id);
        }

        public int InsertDataMore(List<BranchBedEntity> branchFloorEntities)
        {
            BranchBedDAO branchBedDAO = new BranchBedDAO();
            return branchBedDAO.InsertDataMore(branchFloorEntities);
        }

        public int DeleteData(BranchBedEntity entity)
        {
            BranchBedDAO branchBedDAO = new BranchBedDAO();
            return branchBedDAO.DeleteData(entity);
        }
    }
}
