using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class RedFlagDAO : IDAORepository<RedFlagEntity>
    {
        DBHelper DBHelper = null;
        public RedFlagDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<RedFlagEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<RedFlagEntity> GetDataByCondition(RedFlagEntity entity)
        {
            List<RedFlagEntity> entityList = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("customer_id", entity.customer_id);
                        entityList = DBHelper.SelectStoreProcedure<RedFlagEntity>("select_master_red_flag_by_condition").ToList();
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
            return entityList;
        }

        public List<RedFlagEntity> GetDataByCondition(RedFlagEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public RedFlagEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(RedFlagEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(RedFlagEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
