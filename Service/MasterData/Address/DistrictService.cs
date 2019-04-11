using Entity;
using System;
using System.Collections.Generic;
using System.Text;
using DAO;

namespace Service
{
    public class DistrictService : IServiceRepository<DistrictEntity>
    {
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
            DistrictDAO districtDAO = new DistrictDAO();
            return districtDAO.GetDataByProvinceID(province_id);
        }
    }
}
