using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Definitions;
using Entity;

namespace DAO.InventoryLog
{
    public class InventoryLogDAO : IDAORepository<InventoryLogEntity>
    {
        DBHelper DBHelper = null;
        public InventoryLogDAO()
        {
            DBHelper = new DBHelper();
        }
        public List<InventoryLogEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<InventoryLogEntity> GetDataByCondition(InventoryLogEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<InventoryLogEntity> GetDataByCondition(InventoryLogEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public InventoryLogEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(InventoryLogEntity entity)
        {
            int result = 0;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        using (DBHelper.BeginTransaction())
                        {
                            String inventory_log_id = "";

                            if (entity.updateMode == entity.OutBound)
                            {
                                foreach (InventoryLogEntity item in entity.inventoryLogEntityList)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParamOut("inventory_log_id", item.inventory_log_id);
                                    DBHelper.AddParam("inventory_id", item.inventory_id);
                                    DBHelper.AddParam("branch_id", item.branch_id);
                                    DBHelper.AddParam("name", item.name);
                                    DBHelper.AddParam("qty", item.qty);
                                    DBHelper.AddParam("sku", item.sku);
                                    DBHelper.AddParam("serial", item.serial);
                                    DBHelper.AddParam("type_id", item.type_id);
                                    DBHelper.AddParam("category_id", item.category_id);
                                    DBHelper.AddParam("create_by", item.create_by);
                                    DBHelper.AddParam("create_date", item.create_date);
                                    //DBHelper.AddParam("modify_by", item.modify_by);
                                    //DBHelper.AddParam("modify_date", item.modify_date);
                                    DBHelper.AddParam("is_active", item.is_active);
                                    DBHelper.AddParam("is_delete", item.is_delete);
                                    DBHelper.ExecuteStoreProcedure("insert_inventory_log_outbound");
                                    inventory_log_id += DBHelper.GetParamOut<Int32>("inventory_log_id");
                                }
                            }

                            DBHelper.CommitTransaction();
                            result = (inventory_log_id != "") ? int.Parse(inventory_log_id) : 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        DBHelper.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int UpdateData(InventoryLogEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
