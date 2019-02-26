using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAO.AssetType;

namespace Service.AssetType
{
    public class AssetTypeService : IServiceRepository<AssetTypeEntity>
    {
        public List<AssetTypeEntity> GetDataAll()
        {
            AssetTypeDAO dao = new AssetTypeDAO();
            return dao.GetDataAll();
        }

        public List<AssetTypeEntity> GetDataByCondition(AssetTypeEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<AssetTypeEntity> GetDataByCondition(AssetTypeEntity entity, int index)
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
