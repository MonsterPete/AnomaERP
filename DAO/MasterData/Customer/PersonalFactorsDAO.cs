using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class PersonalFactorsDAO : IDAORepository<PersonalFactorsEntity>
    {
        DBHelper DBHelper = null;
        public PersonalFactorsDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<PersonalFactorsEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<PersonalFactorsEntity> GetDataByCondition(PersonalFactorsEntity entity)
        {
            List<PersonalFactorsEntity> entityList = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("customer_id", entity.customer_id);
                        entityList = DBHelper.SelectStoreProcedure<PersonalFactorsEntity>("select_master_personal_factors_by_condition").ToList();
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

        public List<PersonalFactorsEntity> GetDataByCondition(PersonalFactorsEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public PersonalFactorsEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(PersonalFactorsEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(PersonalFactorsEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
