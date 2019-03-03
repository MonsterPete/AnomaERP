using DAO.ServiceCare;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.ServiceCare
{
    public class CarePlanService : IServiceRepository<CarePlanEntity>
    {
        public List<CarePlanEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<CarePlanEntity> GetDataByCondition(CarePlanEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<CarePlanEntity> GetDataByCondition(CarePlanEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public List<CarePlanEntity> GetDataByCustomerId(int customerId)
        {
            CarePlanDAO carePlanDAO = new CarePlanDAO();
            return carePlanDAO.GetDataByCustomerId(customerId);
        }

        public CarePlanEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(CarePlanEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(CarePlanEntity entity)
        {
            throw new NotImplementedException();
        }

        public void InsertOrUpdateMoreData(List<CarePlanEntity> carePlanEntities)
        {
            CarePlanDAO carePlanDAO = new CarePlanDAO();
            carePlanDAO.InsertOrUpdateMoreData(carePlanEntities);
        }
    }
}
