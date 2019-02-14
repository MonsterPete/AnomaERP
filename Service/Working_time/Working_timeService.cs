using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAO.Working_time;

namespace Service.Working_time
{
    public class Working_timeService : IServiceRepository<WorkingTimeEntity>
    {
        public List<WorkingTimeEntity> GetDataAll()
        {
            Working_timeDAO working_TimeDAO = new Working_timeDAO();
            return working_TimeDAO.GetDataAll();
        }

        public List<WorkingTimeEntity> GetDataByCondition(WorkingTimeEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<WorkingTimeEntity> GetDataByCondition(WorkingTimeEntity entity, int index)
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
