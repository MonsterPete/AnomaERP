using Definitions;
using Entity;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DAO.ServiceCare
{
    public class DailyActivitiesDAO : IDAORepository<DailyActivitiesEntity>
    {
        DBHelper DBHelper = null;

        public DailyActivitiesDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<DailyActivitiesEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<DailyActivitiesEntity> GetDataByCondition(DailyActivitiesEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<DailyActivitiesEntity> GetDataByCondition(DailyActivitiesEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public List<DailyActivitiesEntity> GetDataByCustomer(int customerID)
        {
            List<DailyActivitiesEntity> entityEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();

                        DBHelper.AddParam("customer_id", customerID);

                        entityEntities = DBHelper.SelectStoreProcedure<DailyActivitiesEntity>("select_daily_activities_by_customer").ToList();
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
            return entityEntities;
        }

        public DailyActivitiesEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(DailyActivitiesEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(DailyActivitiesEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateDataAccept(DailyActivitiesEntity entity)
        {
            int result = 0;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        using (DBHelper.BeginTransaction())
                        {
                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("success", 0);
                            DBHelper.AddParam("daily_activities_id", entity.daily_activities_id);
                            DBHelper.AddParam("employee_id", entity.employee_id);
                            DBHelper.AddParam("is_done", 0);
                            DBHelper.AddParam("timestamp", null);
                            DBHelper.AddParam("comment", null);

                            DBHelper.ExecuteStoreProcedure("update_daily_activities_by_employee");
                            result = DBHelper.GetParamOut<Int32>("success");
                            DBHelper.CommitTransaction();
                        }
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
            return result;
        }

        public int UpdateDataReject(DailyActivitiesEntity entity)
        {
            int result = 0;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        using (DBHelper.BeginTransaction())
                        {
                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("success", 0);
                            DBHelper.AddParam("daily_activities_id", entity.daily_activities_id);
                            DBHelper.AddParam("employee_id", null);
                            DBHelper.AddParam("is_done", null);
                            DBHelper.AddParam("timestamp", null);
                            DBHelper.AddParam("comment", null);

                            DBHelper.ExecuteStoreProcedure("update_daily_activities_by_employee");
                            result = DBHelper.GetParamOut<Int32>("success");
                            DBHelper.CommitTransaction();
                        }
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
            return result;
        }

    }
}
