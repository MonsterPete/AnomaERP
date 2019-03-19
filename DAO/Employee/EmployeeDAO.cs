using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Definitions;
using Entity;

namespace DAO.Employee
{
    public class EmployeeDAO : IDAORepository<EmployeeEntity>
    {
        DateFormat dateFormat = new DateFormat();
        DBHelper DBHelper = null;

        public EmployeeDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<EmployeeEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<EmployeeEntity> GetDataByCondition(EmployeeEntity entity)
        {
            List<EmployeeEntity> employeeEntities = new List<EmployeeEntity>();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("search", entity.nickname);
                        employeeEntities = DBHelper.SelectStoreProcedure<EmployeeEntity>("select_employee_by_condition").ToList();

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
            return employeeEntities;
        }

        public List<EmployeeEntity> GetDataByCondition(EmployeeEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public EmployeeEntity GetDataByID(long employee_id)
        {
            EmployeeEntity employeeEntity = new EmployeeEntity();
            ShifTimeEntity shifTimeEntity = new ShifTimeEntity();
            DateWorkEntity dateWorkEntity = new DateWorkEntity();

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("employee_id", employee_id);
                        employeeEntity = DBHelper.SelectStoreProcedureFirst<EmployeeEntity>("select_employee_by_id");
                        shifTimeEntity = DBHelper.SelectStoreProcedureFirst<ShifTimeEntity>("select_shif_time_by_employee_id");
                        dateWorkEntity = DBHelper.SelectStoreProcedureFirst<DateWorkEntity>("select_date_work_by_employee_id");

                        if (shifTimeEntity !=null)
                        {
                            employeeEntity.shifTimeEntity = shifTimeEntity;
                        }

                        if (dateWorkEntity !=null)
                        {
                            employeeEntity.dateWorkEntity = dateWorkEntity;
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
            return employeeEntity;
        }

        public int InsertData(EmployeeEntity entity)
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
                            DBHelper.AddParamOut("employee_id", entity.employee_id);
                            DBHelper.AddParam("username", entity.username);
                            DBHelper.AddParam("password", entity.password);
                            DBHelper.AddParam("email", entity.email);
                            DBHelper.AddParam("phone", entity.phone);
                            DBHelper.AddParam("firstname", entity.firstname);
                            DBHelper.AddParam("lastname", entity.lastname);
                            DBHelper.AddParam("nickname", entity.nickname);
                            DBHelper.AddParam("gender", entity.gender);

                            if (entity.date_of_birth !=  default(DateTime))
                            {
                                DBHelper.AddParam("date_of_birth", entity.date_of_birth);
                            }
                           
                            DBHelper.AddParam("citizen_id", entity.citizen_id);
                            DBHelper.AddParam("position_id", entity.position_id);
                            DBHelper.AddParam("working_time_id", entity.working_time_id);
                            DBHelper.AddParam("create_by", entity.create_by);
                            DBHelper.AddParam("create_date", entity.create_date);
                            DBHelper.AddParam("is_active", entity.is_active);
                            DBHelper.AddParam("is_delete", entity.is_delete);
                            DBHelper.ExecuteStoreProcedure("insert_employee");
                            result = DBHelper.GetParamOut<Int32>("employee_id");

                            DBHelper.CreateParameters();
                            DBHelper.AddParam("employee_id", result);
                            DBHelper.AddParam("is_active", 0);
                            DBHelper.AddParam("is_delete", 1);
                            DBHelper.ExecuteStoreProcedure("update_delete_date_work");

                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("date_work_id", entity.dateWorkEntity.date_work_id);
                            DBHelper.AddParam("employee_id", result);
                            DBHelper.AddParam("monday", entity.dateWorkEntity.monday);
                            DBHelper.AddParam("tuesday", entity.dateWorkEntity.tuesday);
                            DBHelper.AddParam("wednesday", entity.dateWorkEntity.wednesday);
                            DBHelper.AddParam("thuresday", entity.dateWorkEntity.thuresday);
                            DBHelper.AddParam("friday", entity.dateWorkEntity.friday);
                            DBHelper.AddParam("saturday", entity.dateWorkEntity.saturday);
                            DBHelper.AddParam("sunday", entity.dateWorkEntity.sunday);
                            DBHelper.AddParam("create_by", entity.create_by);
                            DBHelper.AddParam("create_date", entity.create_date);
                            DBHelper.AddParam("is_active", entity.dateWorkEntity.is_active);
                            DBHelper.AddParam("is_delete", entity.dateWorkEntity.is_delete);
                            DBHelper.ExecuteStoreProcedure("insert_date_work");



                            DBHelper.CreateParameters();
                            DBHelper.AddParam("employee_id", result);
                            DBHelper.AddParam("is_active", 0);
                            DBHelper.AddParam("is_delete", 1);
                            DBHelper.ExecuteStoreProcedure("update_delete_shif_time");

                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("shif_time_id", entity.shifTimeEntity.shif_time_id);
                            DBHelper.AddParam("employee_id", result);

                            if (entity.shifTimeEntity.start_time_1 != default(DateTime).TimeOfDay)
                            {
                                DBHelper.AddParam("start_time_1", dateFormat.EngFormatDateToSQL(DateTime.Parse(entity.shifTimeEntity.start_time_1.ToString())));
                            }

                            if (entity.shifTimeEntity.end_time_1 != default(DateTime).TimeOfDay)
                            {
                                DBHelper.AddParam("end_time_1", dateFormat.EngFormatDateToSQL(DateTime.Parse(entity.shifTimeEntity.end_time_1.ToString())));
                            }

                            if (entity.shifTimeEntity.start_time_2 != default(DateTime).TimeOfDay)
                            {
                                DBHelper.AddParam("start_time_2", dateFormat.EngFormatDateToSQL(DateTime.Parse(entity.shifTimeEntity.start_time_2.ToString())));
                            }

                            if (entity.shifTimeEntity.end_time_2 != default(DateTime).TimeOfDay)
                            {
                                DBHelper.AddParam("end_time_2", dateFormat.EngFormatDateToSQL(DateTime.Parse(entity.shifTimeEntity.end_time_2.ToString())));
                            }

                            if (entity.shifTimeEntity.start_time_3 != default(DateTime).TimeOfDay)
                            {
                                DBHelper.AddParam("start_time_3", dateFormat.EngFormatDateToSQL(DateTime.Parse(entity.shifTimeEntity.start_time_3.ToString())));
                            }

                            if (entity.shifTimeEntity.end_time_3 != default(DateTime).TimeOfDay)
                            {
                                DBHelper.AddParam("end_time_3", dateFormat.EngFormatDateToSQL(DateTime.Parse(entity.shifTimeEntity.end_time_3.ToString())));
                            }
  
                            DBHelper.AddParam("create_by", entity.create_by);
                            DBHelper.AddParam("create_date", entity.create_date);
                            DBHelper.AddParam("is_active", entity.shifTimeEntity.is_active);
                            DBHelper.AddParam("is_delete", entity.shifTimeEntity.is_delete);
                            DBHelper.ExecuteStoreProcedure("insert_shif_time");


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

        public int UpdateData(EmployeeEntity entity)
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
                            DBHelper.AddParam("employee_id", entity.employee_id);
                            DBHelper.AddParam("username", entity.username);
                            DBHelper.AddParam("password", entity.password);
                            DBHelper.AddParam("email", entity.email);
                            DBHelper.AddParam("phone", entity.phone);
                            DBHelper.AddParam("firstname", entity.firstname);
                            DBHelper.AddParam("lastname", entity.lastname);
                            DBHelper.AddParam("nickname", entity.nickname);
                            DBHelper.AddParam("gender", entity.gender);
                            DBHelper.AddParam("date_of_birth", entity.date_of_birth);
                            DBHelper.AddParam("citizen_id", entity.citizen_id);
                            DBHelper.AddParam("position_id", entity.position_id);
                            DBHelper.AddParam("working_time_id", entity.working_time_id);
                            DBHelper.AddParam("create_by", entity.create_by);
                            DBHelper.AddParam("create_date", entity.create_date);
                            DBHelper.AddParam("is_active", entity.is_active);
                            DBHelper.AddParam("is_delete", entity.is_delete);
                            DBHelper.AddParamOut("success_row", result);
                            DBHelper.ExecuteStoreProcedure("update_employee");
                            result = DBHelper.GetParamOut<Int32>("success_row");

                            DBHelper.CreateParameters();
                            DBHelper.AddParam("employee_id", entity.employee_id);
                            DBHelper.AddParam("is_active", 0);
                            DBHelper.AddParam("is_delete", 1);
                            DBHelper.ExecuteStoreProcedure("update_delete_date_work");

                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("date_work_id", entity.dateWorkEntity.date_work_id);
                            DBHelper.AddParam("employee_id", entity.employee_id);
                            DBHelper.AddParam("monday", entity.dateWorkEntity.monday);
                            DBHelper.AddParam("tuesday", entity.dateWorkEntity.tuesday);
                            DBHelper.AddParam("wednesday", entity.dateWorkEntity.wednesday);
                            DBHelper.AddParam("thuresday", entity.dateWorkEntity.thuresday);
                            DBHelper.AddParam("friday", entity.dateWorkEntity.friday);
                            DBHelper.AddParam("saturday", entity.dateWorkEntity.saturday);
                            DBHelper.AddParam("sunday", entity.dateWorkEntity.sunday);
                            DBHelper.AddParam("create_by", entity.create_by);
                            DBHelper.AddParam("create_date", entity.create_date);
                            DBHelper.AddParam("is_active", entity.dateWorkEntity.is_active);
                            DBHelper.AddParam("is_delete", entity.dateWorkEntity.is_delete);
                            DBHelper.ExecuteStoreProcedure("insert_date_work");


                            DBHelper.CreateParameters();
                            DBHelper.AddParam("employee_id", entity.employee_id);
                            DBHelper.AddParam("is_active", 0);
                            DBHelper.AddParam("is_delete", 1);
                            DBHelper.ExecuteStoreProcedure("update_delete_shif_time");

                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("shif_time_id", entity.shifTimeEntity.shif_time_id);
                            DBHelper.AddParam("employee_id", entity.employee_id);
                            DBHelper.AddParam("start_time_1", dateFormat.EngFormatDateToSQL(DateTime.Parse(entity.shifTimeEntity.start_time_1.ToString())));
                            DBHelper.AddParam("end_time_1", dateFormat.EngFormatDateToSQL(DateTime.Parse(entity.shifTimeEntity.end_time_1.ToString())));
                            DBHelper.AddParam("start_time_2", dateFormat.EngFormatDateToSQL(DateTime.Parse(entity.shifTimeEntity.start_time_2.ToString())));
                            DBHelper.AddParam("end_time_2", dateFormat.EngFormatDateToSQL(DateTime.Parse(entity.shifTimeEntity.end_time_2.ToString())));
                            DBHelper.AddParam("start_time_3", dateFormat.EngFormatDateToSQL(DateTime.Parse(entity.shifTimeEntity.start_time_3.ToString())));
                            DBHelper.AddParam("end_time_3", dateFormat.EngFormatDateToSQL(DateTime.Parse(entity.shifTimeEntity.end_time_3.ToString())));
                            DBHelper.AddParam("create_by", entity.create_by);
                            DBHelper.AddParam("create_date", entity.create_date);
                            DBHelper.AddParam("is_active", entity.shifTimeEntity.is_active);
                            DBHelper.AddParam("is_delete", entity.shifTimeEntity.is_delete);
                            DBHelper.ExecuteStoreProcedure("insert_shif_time");


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

        public int UpdateStatusData(EmployeeEntity entity)
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
                            DBHelper.AddParam("employee_id", entity.employee_id);
                            DBHelper.AddParam("is_active", entity.is_active);
                            DBHelper.AddParamOut("success_row", result);
                            DBHelper.ExecuteStoreProcedure("update_employee");
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
    }
}
