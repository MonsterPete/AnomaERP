using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO.Branch.BranchBuilding
{
    public class BranchFloorDAO : IDAORepository<BranchFloorEntity>
    {
        DBHelper DBHelper = null;

        public BranchFloorDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<BranchFloorEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<BranchFloorEntity> GetDataByCondition(BranchFloorEntity entity)
        {
            List<BranchFloorEntity> branchFloorEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("room_id", entity.branch_id);
                        DBHelper.AddParam("floor_id", entity.floor_id);
                        DBHelper.AddParam("floor_name", entity.floor_name);
                        DBHelper.AddParam("is_active", entity.is_active);
                        branchFloorEntities = DBHelper.SelectStoreProcedure<BranchFloorEntity>("select_branch_floor_by_condition").ToList();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        DBHelper.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return branchFloorEntities;
        }

        public List<BranchFloorEntity> GetDataByCondition(BranchFloorEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public BranchFloorEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(BranchFloorEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(BranchFloorEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
