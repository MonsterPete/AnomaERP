using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAO.InventoryLog;


namespace Service.InventoryLog
{
    public class InventoryLogService : IServiceRepository<InventoryLogEntity>
    {
        public List<InventoryLogEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<InventoryLogEntity> GetDataByCondition(InventoryLogEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<InventoryLogEntity> GetDataByCondition(InventoryLogEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public InventoryLogEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(InventoryLogEntity entity)
        {
            InventoryLogDAO dao = new InventoryLogDAO();
            return dao.InsertData(entity);
        }

        public int UpdateData(InventoryLogEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
