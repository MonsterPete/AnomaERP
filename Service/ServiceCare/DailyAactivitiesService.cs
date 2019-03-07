using DAO.ServiceCare;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.ServiceCare
{
    public class DailyAactivitiesService : IServiceRepository<DailyActivitiesEntity>
    {
        public List<DailyActivitiesEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<DailyActivitiesEntity> GetDataByCondition(DailyActivitiesEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<DailyActivitiesEntity> GetDataByCondition(DailyActivitiesEntity entity, int index)
        {
            throw new NotImplementedException();
        }
        public List<DailyActivitiesEntity> GetDataByCustomer(int customerID)
        {
            DailyActivitiesDAO dao = new DailyActivitiesDAO();
            return dao.GetDataByCustomer(customerID);
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
            DailyActivitiesDAO dao = new DailyActivitiesDAO();
            return dao.UpdateDataAccept(entity);
        }
        public int UpdateDataReject(DailyActivitiesEntity entity)
        {
            DailyActivitiesDAO dao = new DailyActivitiesDAO();
            return dao.UpdateDataReject(entity);
        }


    }
}
