using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class DistrictDAO : IDAORepository<DistrictEntity>
    {
        DBHelper DBHelper = null;

        public DistrictDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<DistrictEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<DistrictEntity> GetDataByCondition(DistrictEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<DistrictEntity> GetDataByCondition(DistrictEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public DistrictEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(DistrictEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(DistrictEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<DistrictEntity> GetDataByProvinceID(int province_id)
        {
            List<DistrictEntity> districtEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("province_id", province_id);
                        districtEntities = DBHelper.SelectStoreProcedure<DistrictEntity>("select_district_by_province_id").ToList();
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
            return districtEntities;
        }
    }
}
