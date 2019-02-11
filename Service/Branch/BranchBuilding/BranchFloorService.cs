using Entity;
using System;
using System.Collections.Generic;
using System.Text;
using DAO.Branch.BranchBuilding;

namespace Service.Branch.BranchBuilding
{
    public class BranchFloorService : IServiceRepository<BranchFloorEntity>
    {
        public List<BranchFloorEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<BranchFloorEntity> GetDataByCondition(BranchFloorEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<BranchFloorEntity> GetDataByCondition(BranchFloorEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public BranchFloorEntity GetDataByID(long id)
        {
            BranchFloorDAO branchFloorDAO = new BranchFloorDAO();
            return branchFloorDAO.GetDataByID(id);
        }

        public int InsertData(BranchFloorEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(BranchFloorEntity entity)
        {
            BranchFloorDAO branchFloorDAO = new BranchFloorDAO();
            return branchFloorDAO.UpdateData(entity);
        }

        public List<BranchFloorEntity> GetDataBranchFloorByID(int Branch_id)
        {
            BranchFloorDAO branchFloorDAO = new BranchFloorDAO();
            return branchFloorDAO.GetDataBranchFloorByID(Branch_id);
        }

        public int InsertDataMore(List<BranchFloorEntity> branchFloorEntity)
        {
            BranchFloorDAO branchFloorDAO = new BranchFloorDAO();
            return branchFloorDAO.InsertDataMore(branchFloorEntity);
        }

        public int DeleteData(BranchFloorEntity entity)
        {
            BranchFloorDAO branchFloorDAO = new BranchFloorDAO();
            return branchFloorDAO.DeleteData(entity);
        }
    }
}
