using DAO;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class CongenitalDiseaseService : IServiceRepository<CongenitalDiseaseEntity>
    {
        public List<CongenitalDiseaseEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<CongenitalDiseaseEntity> GetDataByCondition(CongenitalDiseaseEntity entity)
        {
            CongenitalDiseaseDAO congenitalDiseaseDAO = new CongenitalDiseaseDAO();
            return congenitalDiseaseDAO.GetDataByCondition(entity);
        }

        public List<CongenitalDiseaseEntity> GetDataByCondition(CongenitalDiseaseEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public CongenitalDiseaseEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(CongenitalDiseaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(CongenitalDiseaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
