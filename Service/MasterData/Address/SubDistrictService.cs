using Entity;
using System;
using System.Collections.Generic;
using System.Text;
using DAO;

namespace Service
{
    public class SubDistrictService : IServiceRepository<SubDistrictEntity>
    {
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
            SubDistrictDAO subDistrictDAO = new SubDistrictDAO();
            return subDistrictDAO.GetDataByDistrictID(district_id);
        }
    }
}
