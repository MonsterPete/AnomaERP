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
    }
}
