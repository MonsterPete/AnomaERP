using DAO.ServiceCare;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.ServiceCare
{
    public class DayActivitiesService : IServiceRepository<DailyActivitiesEntity>
    {
        public List<DailyActivitiesEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<DailyActivitiesEntity> GetDataByCondition(DailyActivitiesEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<DayActivitiesAndExtraEntity> GetDayAndExtraByCondition(DayActivities entity)
        {
            DayActicitiesDAO dayActicitiesDAO = new DayActicitiesDAO();
            return dayActicitiesDAO.GetDayAndExtraByCondition(entity);
        }

        public List<DailyActivitiesEntity> GetDataByCondition(DailyActivitiesEntity entity, int index)
        {
            throw new NotImplementedException();
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
    }
}
