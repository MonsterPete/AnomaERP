using DAO;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class RiskAssessmentService : IServiceRepository<RiskAssessmentEntity>
    {
        public List<RiskAssessmentEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<RiskAssessmentEntity> GetDataByCondition(RiskAssessmentEntity entity)
        {
            RiskAssessmentDAO riskAssessmentDAO = new RiskAssessmentDAO();
            return riskAssessmentDAO.GetDataByCondition(entity);
        }

        public List<RiskAssessmentEntity> GetDataByCondition(RiskAssessmentEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public RiskAssessmentEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(RiskAssessmentEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(RiskAssessmentEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
