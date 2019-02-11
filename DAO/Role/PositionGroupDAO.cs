using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Definitions;
using Entity;

namespace DAO.Role
{
    public class PositionGroupDAO : IDAORepository<PositionGroupEntity>
    {
        DBHelper DBHelper = null;

        public PositionGroupDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<PositionGroupEntity> GetDataAll()
        {
            List<PositionGroupEntity> positionGroupEntities = new List<PositionGroupEntity>();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();

                        positionGroupEntities = DBHelper.SelectStoreProcedure<PositionGroupEntity>("select_all_position_group").ToList();

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
            return positionGroupEntities;
        }

        public List<PositionGroupEntity> GetDataByCondition(PositionGroupEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<PositionGroupEntity> GetDataByCondition(PositionGroupEntity entity, int Index)
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
