using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO.Branch.BranchBuilding
{
    public class BranchBedDAO : IDAORepository<BranchBedEntity>
    {
        DBHelper DBHelper = null;

        public BranchBedDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<BranchBedEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<BranchBedEntity> GetDataByCondition(BranchBedEntity entity)
        {
            List<BranchBedEntity> branchBedEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("bed_id", entity.bed_id);
                        DBHelper.AddParam("room_id", entity.room_id);
                        DBHelper.AddParam("floor_id", entity.floor_id);
                        DBHelper.AddParam("bed_name", entity.bed_name);
                        DBHelper.AddParam("is_active", entity.is_active);
                        branchBedEntities = DBHelper.SelectStoreProcedure<BranchBedEntity>("select_branch_bed_by_condition").ToList();
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

            return branchBedEntities;
        }

        public List<BranchBedEntity> GetDataByCondition(BranchBedEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public BranchBedEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(BranchBedEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(BranchBedEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
