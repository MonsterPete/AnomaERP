using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class SubDistrictDAO : IDAORepository<SubDistrictEntity>
    {
        DBHelper DBHelper = null;

        public SubDistrictDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<SubDistrictEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<SubDistrictEntity> GetDataByCondition(SubDistrictEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<SubDistrictEntity> GetDataByCondition(SubDistrictEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public SubDistrictEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(SubDistrictEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(SubDistrictEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<SubDistrictEntity> GetDataByDistrictID(int district_id)
        {
            List<SubDistrictEntity> subDistrictEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("district_id", district_id);
                        subDistrictEntities = DBHelper.SelectStoreProcedure<SubDistrictEntity>("select_sub_district_by_district_id").ToList();
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
            return subDistrictEntities;
        }
    }
}
