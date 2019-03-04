using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAO.BedManagement;

namespace Service.BedManagement
{
    public class BedInventoryService : IServiceRepository<InventoryEntity>
    {
        public List<InventoryEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<InventoryEntity> GetDataByCondition(InventoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<InventoryEntity> GetDataByCondition(InventoryEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public InventoryEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(InventoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(InventoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public int InsertDataMore(List<InventoryEntity> inventoryEntities)
        {
            BedInventoryDAO bedInventoryDAO = new BedInventoryDAO();
            return bedInventoryDAO.InsertDataMore(inventoryEntities);
        }

        public int InsertDataMore_return(List<InventoryEntity> inventoryEntities)
        {
            BedInventoryDAO bedInventoryDAO = new BedInventoryDAO();
            return bedInventoryDAO.InsertDataMore_return(inventoryEntities);
        }


        public BedCustomerEntity GetDateBedCustomerByBedID(int bed_id)
        {
            BedInventoryDAO bedInventoryDAO = new BedInventoryDAO();
            return bedInventoryDAO.GetDateBedCustomerByBedID(bed_id);
        }
        
        public List<InventoryEntity> GetDateBedInventoryByBedID(int bed_id)
        {
            BedInventoryDAO bedInventoryDAO = new BedInventoryDAO();
            return bedInventoryDAO.GetDateBedInventoryByBedID(bed_id);
        }
    }
}
