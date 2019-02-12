using DAO.Role;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Role
{
    public class TaskGroupService : IServiceRepository<TaskGroupEntity>
    {
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
            TaskGroupDAO taskGroupDAO = new TaskGroupDAO();
            return taskGroupDAO.GetDataByTaskGroupByTaskId(taskId);
        }

        public List<TaskGroupEntity> GetDataByCondition(TaskGroupEntity entity, int index)
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
