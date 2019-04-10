using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class RiskAssessmentDAO : IDAORepository<RiskAssessmentEntity>
    {
        DBHelper DBHelper = null;
        public RiskAssessmentDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<RiskAssessmentEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<RiskAssessmentEntity> GetDataByCondition(RiskAssessmentEntity entity)
        {
            List<RiskAssessmentEntity> entityList = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("customer_id", entity.customer_id);
                        entityList = DBHelper.SelectStoreProcedure<RiskAssessmentEntity>("select_master_risk_assessment_by_condition").ToList();
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

        public List<RiskAssessmentEntity> GetDataByCondition(RiskAssessmentEntity entity, int Index)
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
