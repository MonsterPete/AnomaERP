using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO.ServiceCare
{
    public class CarePlanDAO : IDAORepository<CarePlanEntity>
    {
        DBHelper DBHelper = null;

        public CarePlanDAO()
        {
            DBHelper = new DBHelper();
        }
        public List<CarePlanEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<CarePlanEntity> GetDataByCondition(CarePlanEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<CarePlanEntity> GetDataByCondition(CarePlanEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public CarePlanEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public List<CarePlanEntity> GetDataByCustomerId(int customerId)
        {
            List<CarePlanEntity> carePlanEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("customer_id", customerId);

                        carePlanEntities = DBHelper.SelectStoreProcedure<CarePlanEntity>("select_care_plan_by_customer_id").ToList();
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
            return carePlanEntities;
        }

        public int InsertData(CarePlanEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(CarePlanEntity entity)
        {
            throw new NotImplementedException();
        }

        public int InsertOrUpdateMoreData(List<CarePlanEntity> carePlanEntities)
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
                            foreach (CarePlanEntity index in carePlanEntities)
                            {
                                if (index.care_plan_id == 0 && !index.is_delete)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParamOut("care_plan_id", index.care_plan_id);
                                    DBHelper.AddParam("start_time", index.start_time);
                                    DBHelper.AddParam("end_time", index.end_time);
                                    DBHelper.AddParam("customer_id", index.customer_id);
                                    DBHelper.AddParam("task_id", index.task_id);
                                    DBHelper.AddParam("is_delete", index.is_delete);
                                    DBHelper.ExecuteStoreProcedure("insert_care_plan");
                                    result = DBHelper.GetParamOut<Int32>("care_plan_id");
                                }
                                else
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParam("care_plan_id", index.care_plan_id);
                                    DBHelper.AddParam("start_time", index.start_time);
                                    DBHelper.AddParam("end_time", index.end_time);
                                    DBHelper.AddParam("customer_id", index.customer_id);
                                    DBHelper.AddParam("task_id", index.task_id);
                                    DBHelper.AddParam("is_delete", index.is_delete);
                                    DBHelper.ExecuteStoreProcedure("update_care_plan");
                                }
                            }
                            DBHelper.CommitTransaction();
                        }
                    }
                    catch (Exception ex)
                    {
                        result = 0;
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
