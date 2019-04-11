using Entity;
using System;
using System.Collections.Generic;
using System.Text;
using DAO;

namespace Service
{
    public class ProvinceService : IServiceRepository<ProvinceEntity>
    {
        public List<ProvinceEntity> GetDataAll()
        {
            ProvinceDAO provinceDAO = new ProvinceDAO();
            return provinceDAO.GetDataAll();
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
