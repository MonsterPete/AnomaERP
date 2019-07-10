using Definitions;
using Entity;
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

        public List<Visit_fileEntity> GetDataVisitFileByVisitorID(int visit_id)
        {
            List<Visit_fileEntity> visit_FileEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("visit_id", visit_id);
                        visit_FileEntities = DBHelper.SelectStoreProcedure<Visit_fileEntity>("select_visit_file_by_visit_id").ToList();
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
            return visit_FileEntities;
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
                            DBHelper.AddParam("appointment_time", entity.appointment_time);
                            DBHelper.AddParam("create_date", entity.create_date);
                            DBHelper.AddParam("create_by", entity.create_by);
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
                            DBHelper.AddParam("visit_id", entity.visit_id);
                            DBHelper.AddParam("visit_time", entity.visit_time);
                            DBHelper.AddParam("is_appointment", entity.is_appointment);
                            DBHelper.AddParam("modify_date", entity.modify_date);
                            DBHelper.AddParam("modify_by", entity.modify_by);
                            DBHelper.AddParamOut("success_row", result);
                            DBHelper.ExecuteStoreProcedure("update_visit");
                            result = DBHelper.GetParamOut<Int32>("success_row");

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

        public int InsertVisitFile(Visit_fileEntity visit_FileEntity)
        {
            Int32 visit_file_id = 0;
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
                            DBHelper.AddParamOut("visit_file_id", visit_FileEntity.visit_file_id);
                            DBHelper.AddParam("visit_id", visit_FileEntity.visit_id);
                            DBHelper.AddParam("file_name", visit_FileEntity.file_name);
                            DBHelper.AddParam("url", visit_FileEntity.url);
                            DBHelper.AddParam("created_date", visit_FileEntity.created_date);
                            DBHelper.AddParam("created_by", visit_FileEntity.created_by);
                            DBHelper.AddParam("is_active", visit_FileEntity.is_active);
                            DBHelper.AddParam("is_delete", visit_FileEntity.is_delete);
                            DBHelper.ExecuteStoreProcedure("insert_visit_file");
                            visit_file_id = DBHelper.GetParamOut<Int32>("visit_file_id");
                            DBHelper.CommitTransaction();
                            result = visit_file_id;
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

        public int DeleteVisitFile(Visit_fileEntity visit_FileEntity)
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
                            DBHelper.AddParam("visit_file_id", visit_FileEntity.visit_file_id);
                            DBHelper.AddParam("is_delete", visit_FileEntity.is_delete);
                            DBHelper.AddParamOut("success_row", result);
                            DBHelper.ExecuteStoreProcedure("update_visit_file");
                            DBHelper.CommitTransaction();
                            result = DBHelper.GetParamOut<Int32>("success_row");    
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
