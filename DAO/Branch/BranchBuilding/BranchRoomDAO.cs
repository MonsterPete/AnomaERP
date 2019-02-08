using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO.Branch.BranchBuilding
{
    public class BranchRoomDAO : IDAORepository<BranchRoomEntity>
    {
        DBHelper DBHelper = null;

        public BranchRoomDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<BranchRoomEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<BranchRoomEntity> GetDataByCondition(BranchRoomEntity entity)
        {
            List<BranchRoomEntity> branchRoomEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("room_id", entity.room_id);
                        DBHelper.AddParam("floor_id", entity.floor_id);
                        DBHelper.AddParam("room_name", entity.room_name);
                        DBHelper.AddParam("is_active", entity.is_active);
                        branchRoomEntities = DBHelper.SelectStoreProcedure<BranchRoomEntity>("select_branch_room_by_condition").ToList();
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

            return branchRoomEntities;
        }

        public List<BranchRoomEntity> GetDataByCondition(BranchRoomEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public BranchRoomEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(BranchRoomEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(BranchRoomEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
