using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Definitions;
using Entity;

namespace DAO.Inventory
{
    public class InventoryDAO : IDAORepository<InventoryEntity>
    {
        public List<InventoryEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<InventoryEntity> GetDataByCondition(InventoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<InventoryEntity> GetDataByCondition(InventoryEntity entity, int Index)
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
