using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Definitions;
using Entity;

namespace DAO.Working_time
{
    public class Working_timeDAO : IDAORepository<WorkingTimeEntity>
    {
        DBHelper DBHelper = null;

        public Working_timeDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<WorkingTimeEntity> GetDataAll()
        {          
            List<WorkingTimeEntity> workingTimeEntities = new List<WorkingTimeEntity>();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        workingTimeEntities = DBHelper.SelectStoreProcedure<WorkingTimeEntity>("select_all_working_time").ToList();

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
            return workingTimeEntities;
        }

        public List<WorkingTimeEntity> GetDataByCondition(WorkingTimeEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<WorkingTimeEntity> GetDataByCondition(WorkingTimeEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public WorkingTimeEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(WorkingTimeEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(WorkingTimeEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
