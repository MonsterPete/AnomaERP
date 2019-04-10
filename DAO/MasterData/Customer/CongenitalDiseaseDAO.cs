using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class CongenitalDiseaseDAO : IDAORepository<CongenitalDiseaseEntity>
    {
        DBHelper DBHelper = null;
        public CongenitalDiseaseDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<CongenitalDiseaseEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<CongenitalDiseaseEntity> GetDataByCondition(CongenitalDiseaseEntity entity)
        {
            List<CongenitalDiseaseEntity> entityList = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("customer_id", entity.customer_id);
                        entityList = DBHelper.SelectStoreProcedure<CongenitalDiseaseEntity>("select_master_congenital_disease_by_condition").ToList();
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

        public List<CongenitalDiseaseEntity> GetDataByCondition(CongenitalDiseaseEntity entity, int Index)
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
