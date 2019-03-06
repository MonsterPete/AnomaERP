using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO.ServiceCare
{
    public class DayActicitiesDAO : IDAORepository<DayActivities>
    {
        DBHelper DBHelper = null;

        public DayActicitiesDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<DayActivities> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<DayActivities> GetDataByCondition(DayActivities entity)
        {
            throw new NotImplementedException();
        }

        public List<DayActivities> GetDataByCondition(DayActivities entity, int Index)
        {
            throw new NotImplementedException();
        }

        public DayActivities GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(DayActivities entity)
        {
            throw new NotImplementedException();
        }

        public List<DayActivitiesAndExtraEntity> GetDayAndExtraByCondition(DayActivities entity)
        {
            List<DayActivitiesAndExtraEntity> dayActivitiesAndExtraEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("customer_id", entity.customer_id);

                        dayActivitiesAndExtraEntities = DBHelper.SelectStoreProcedure<DayActivitiesAndExtraEntity>("select_dayactivities_extraactivities_customer_id").ToList();
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
            return dayActivitiesAndExtraEntities;
        }

        public int UpdateData(DayActivities entity)
        {
            throw new NotImplementedException();
        }
    }
}
