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
        DBHelper DBHelper = null;
        public InventoryDAO()
        {
            DBHelper = new DBHelper();
        }
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
                            String inventory_id = "";

                            if (entity.updateMode == entity.Inbound)
                            {
                                foreach (var item in entity.inventoryEntityList)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParamOut("inventory_id", entity.inventory_id);
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
                                    DBHelper.ExecuteStoreProcedure("insert_inventory_inbound");
                                    inventory_id += DBHelper.GetParamOut<Int32>("inventory_id");
                                }
                            }

                            DBHelper.CommitTransaction();
                            result = (inventory_id != "") ? int.Parse(inventory_id) : 0;
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

        public int UpdateData(InventoryEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
