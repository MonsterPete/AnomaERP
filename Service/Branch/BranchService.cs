using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAO.Branch;

namespace Service.Branch
{
    public class BranchService : IServiceRepository<BranchEntity>
    {
        public List<BranchEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<BranchEntity> GetDataByCondition(BranchEntity entity)
        {
            BranchDAO branchDAO = new BranchDAO();
            return branchDAO.GetDataByCondition(entity);
        }

        public List<BranchEntity> GetDataByCondition(BranchEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public List<BranchEntity> GetDataByEntity(int entity_id)
        {
            BranchDAO branchDAO = new BranchDAO();
            return branchDAO.GetDataByEntity(entity_id);
        }
        
        public BranchEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        

        public int InsertData(BranchEntity entity)
        {
            BranchDAO branchDAO = new BranchDAO();
            return branchDAO.InsertData(entity);
        }

        public int UpdateData(BranchEntity entity)
        {
            BranchDAO branchDAO = new BranchDAO();
            return branchDAO.UpdateData(entity);
        }

        public BranchEntity GetDataBranchByID(int branch_id)
        {
            BranchDAO branchDAO = new BranchDAO();
            return branchDAO.GetDataBranchByID(branch_id);
        }


        public user_loginEntity GetAlllogin(string username, string password)
        {
            BranchDAO branchDAO = new BranchDAO();
            return branchDAO.GetAlllogin(username, password);
        }

        public user_loginEntity CheckUsernameRepeat(string username, int user_id)
        {
            BranchDAO branchDAO = new BranchDAO();
            return branchDAO.CheckUsernameRepeat(username, user_id);
        }

        public List<BuildingTypeEntity> GetDataBuildingTypeAll()
        {
            BranchDAO branchDAO = new BranchDAO();
            return branchDAO.GetDataBuildingTypeAll();
        }
    }
}
