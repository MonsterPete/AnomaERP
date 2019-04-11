using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class ProvinceDAO : IDAORepository<ProvinceEntity>
    {
        DBHelper DBHelper = null;

        public ProvinceDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<ProvinceEntity> GetDataAll()
        {
            List<ProvinceEntity> provinceEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        provinceEntities = DBHelper.SelectStoreProcedure<ProvinceEntity>("select_all_province").ToList();
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
            return provinceEntities;
        }

        public List<ProvinceEntity> GetDataByCondition(ProvinceEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<ProvinceEntity> GetDataByCondition(ProvinceEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public ProvinceEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(ProvinceEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(ProvinceEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
