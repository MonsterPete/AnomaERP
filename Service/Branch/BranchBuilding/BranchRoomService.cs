using Entity;
using System;
using System.Collections.Generic;
using System.Text;
using DAO.Branch.BranchBuilding;

namespace Service.Branch.BranchBuilding
{
    public class BranchRoomService : IServiceRepository<BranchRoomEntity>
    {
        public List<BranchRoomEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<BranchRoomEntity> GetDataByCondition(BranchRoomEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<BranchRoomEntity> GetDataByCondition(BranchRoomEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public BranchRoomEntity GetDataByID(long id)
        {
            BranchRoomDAO branchRoomDAO = new BranchRoomDAO();
            return branchRoomDAO.GetDataByID(id);
        }

        public int InsertData(BranchRoomEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(BranchRoomEntity entity)
        {
            BranchRoomDAO branchRoomDAO = new BranchRoomDAO();
            return branchRoomDAO.UpdateData(entity);
        }
        public List<BranchRoomEntity> GetDataBranchRoomByID(int Floor_id)
        {
            BranchRoomDAO branchRoomDAO = new BranchRoomDAO();
            return branchRoomDAO.GetDataBranchRoomByID(Floor_id);
        }

        public int InsertDataMore(List<BranchRoomEntity> branchFloorEntities)
        {
            BranchRoomDAO branchRoomDAO = new BranchRoomDAO();
            return branchRoomDAO.InsertDataMore(branchFloorEntities);
        }

        public int DeleteData(BranchRoomEntity entity)
        {
            BranchRoomDAO branchRoomDAO = new BranchRoomDAO();
            return branchRoomDAO.DeleteData(entity);
        }
    }
}
