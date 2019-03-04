using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAO.Inventory;


namespace Service.Inventory
{
    public class InventoryService : IServiceRepository<InventoryEntity>
    {
        public List<InventoryEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<InventoryEntity> GetDataByCondition(InventoryEntity entity)
        {
            InventoryDAO dao = new InventoryDAO();
            return dao.GetDataByCondition(entity);
        }

        public List<InventoryEntity> GetDataByCondition(InventoryEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public InventoryEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public List<InventoryEntity> GetSkuAll()
        {
            InventoryDAO dao = new InventoryDAO();
            return dao.GetSkuAll();
        }
        public List<InventoryEntity> GetDataBySku(String sku)
        {
            InventoryDAO dao = new InventoryDAO();
            return dao.GetDataBySku(sku);
        }
        public List<InventoryEntity> GetDataBySku(InventoryEntity entity)
        {
            InventoryDAO dao = new InventoryDAO();
            return dao.GetDataBySku(entity);
        }
        public List<InventoryEntity> GetDataBySerial(InventoryEntity entity)
        {
            InventoryDAO dao = new InventoryDAO();
            return dao.GetDataBySerial(entity);
        }
        public List<InventoryEntity> GetDataByDate(InventoryEntity entity)
        {
            InventoryDAO dao = new InventoryDAO();
            return dao.GetDataByDate(entity);
        }
        public List<InventoryEntity> CheckDuplicateData(InventoryEntity entity)
        {
            InventoryDAO dao = new InventoryDAO();
            return dao.CheckDuplicateData(entity);
        }

        public int InsertData(InventoryEntity entity)
        {
            InventoryDAO dao = new InventoryDAO();
            return dao.InsertData(entity);
        }

        public int UpdateData(InventoryEntity entity)
        {
            throw new NotImplementedException();
        }
        public int UpdateQtyTotle(InventoryEntity entity)
        {
            InventoryDAO dao = new InventoryDAO();
            return dao.UpdateQtyTotle(entity);
        }

        public List<InventoryEntity> GetSkuTotalMoreZero()
        {
            InventoryDAO dao = new InventoryDAO();
            return dao.GetSkuTotalMoreZero();
        }
    }
}
