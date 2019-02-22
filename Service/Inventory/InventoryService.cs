using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAO.Inventory;


namespace Service
{
    public class InventoryService : IServiceRepository<InventoryEntity>
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
    }
}
