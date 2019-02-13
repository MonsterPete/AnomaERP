using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO.Role
{
    public class TaskGroupDAO : IDAORepository<TaskGroupEntity>
    {
        DBHelper DBHelper = null;

        public TaskGroupDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<TaskGroupEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<TaskGroupEntity> GetDataByCondition(TaskGroupEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<TaskGroupEntity> GetDataByTaskGroupByTaskId(int taskId)
        {
            List<TaskGroupEntity> taskGroupEntities = new List<TaskGroupEntity>();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("task_id", taskId);

                        taskGroupEntities = DBHelper.SelectStoreProcedure<TaskGroupEntity>("select_task_group_by_task_id").ToList();

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
            return taskGroupEntities;
        }

        public List<TaskGroupEntity> GetDataByCondition(TaskGroupEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public TaskGroupEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(TaskGroupEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(TaskGroupEntity entity)
        {
            throw new NotImplementedException();
        }


        public int InsertAndUpdateDataMore(List<TaskGroupEntity> taskGroupEntities)
        {
            int result = 0;
            int param_out_id = 0;
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();

                        foreach (var item in taskGroupEntities)
                        {
                            if (item.task_group_id > 0 )
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParamOut("success_row", result);
                                DBHelper.AddParam("task_group_id", item.task_group_id);
                                DBHelper.AddParam("position_id", item.position_id);
                                DBHelper.AddParam("task_id", item.task_id);
                                DBHelper.AddParam("create_by", item.create_by);
                                DBHelper.AddParam("create_date", item.create_date);
                                DBHelper.AddParam("is_active", item.is_active);
                                DBHelper.AddParam("is_delete", item.is_delete);
                                DBHelper.ExecuteStoreProcedure("update_task_group");
                                param_out_id = DBHelper.GetParamOut<Int32>("success_row");
                            }
                            else
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParamOut("task_group_id", item.task_group_id);
                                DBHelper.AddParam("position_id", item.position_id);
                                DBHelper.AddParam("task_id", item.task_id);
                                DBHelper.AddParam("create_by", item.create_by);
                                DBHelper.AddParam("create_date", item.create_date);
                                DBHelper.AddParam("is_active", item.is_active);
                                DBHelper.AddParam("is_delete", item.is_delete);
                                DBHelper.ExecuteStoreProcedure("insert_task_group");
                                param_out_id = DBHelper.GetParamOut<Int32>("task_group_id");
                            }
                            result += param_out_id;
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
