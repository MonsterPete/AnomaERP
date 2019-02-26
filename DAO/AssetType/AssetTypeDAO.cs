using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Definitions;
using Entity;

namespace DAO.AssetType
{
    public class AssetTypeDAO : IDAORepository<AssetTypeEntity>
    {
        DBHelper DBHelper = null;
        public AssetTypeDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<AssetTypeEntity> GetDataAll()
        {
            List<AssetTypeEntity> entityList = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        
                        entityList = DBHelper.SelectStoreProcedure<AssetTypeEntity>("select_asset_type_all").ToList();
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

        public List<AssetTypeEntity> GetDataByCondition(AssetTypeEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<AssetTypeEntity> GetDataByCondition(AssetTypeEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public AssetTypeEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(AssetTypeEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(AssetTypeEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
