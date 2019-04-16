using Definitions;
using Entity.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO.Customer
{
    public class VisitDAO : IDAORepository<VisitEntity>
    {
        DBHelper DBHelper = null;

        public VisitDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<VisitEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<VisitEntity> GetDataByCondition(VisitEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<VisitEntity> GetDataByCondition(VisitEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public List<VisitEntity> GetDataByCustomerID(long id)
        {
            List<VisitEntity> visitEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();

                        DBHelper.AddParam("customer_id", id);


                        visitEntities = DBHelper.SelectStoreProcedure<VisitEntity>("select_visit_by_customer_id").ToList();
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
            return visitEntities;
        }

        public VisitEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(VisitEntity entity)
        {
            Int32 visit_id = 0;
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
                            DBHelper.AddParamOut("visit_id", entity.visit_id);
                            DBHelper.AddParam("customer_id", entity.customer_id);
                            DBHelper.AddParam("visit_code", entity.visit_code);
                            DBHelper.AddParam("visit_type", entity.visit_type);
                            DBHelper.AddParam("create_date", DateTime.Now);
                            DBHelper.AddParam("running_number_id", entity.running_number_id);
                            DBHelper.AddParam("branch_id", entity.branch_id);
                            DBHelper.ExecuteStoreProcedure("insert_visit");
                            visit_id = DBHelper.GetParamOut<Int32>("visit_id");

                            DBHelper.CommitTransaction();
                            result = visit_id;
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

        public int UpdateData(VisitEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
