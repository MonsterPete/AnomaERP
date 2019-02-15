using DAO.BedManagement;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.BedManagement
{
    public class BedCustomerService : IServiceRepository<BedCustomerEntity>
    {
        public List<BedCustomerEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<BedCustomerEntity> GetDataByCondition(BedCustomerEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<BedCustomerEntity> GetDataByCondition(BedCustomerEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public BedCustomerEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(BedCustomerEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(BedCustomerEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<BedCustomerEntity> SelectBedCustomerForBedEntity(BedCustomerEntity bedCustomerEntity)
        {
            BedCustomerDAO bedCustomerDAO = new BedCustomerDAO();
            return bedCustomerDAO.SelectBedCustomerForBedEntity(bedCustomerEntity);
        }
    }
}
