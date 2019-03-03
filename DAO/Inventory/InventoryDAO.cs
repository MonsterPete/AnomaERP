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
            List<InventoryEntity> entityList = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();

                        DBHelper.AddParam("word", entity.sch_word);
                        DBHelper.AddParam("branch_id", entity.sch_branch_id);
                        DBHelper.AddParam("category_id", entity.sch_category_id);

                        entityList = DBHelper.SelectStoreProcedure<InventoryEntity>("select_inventory_by_condition").ToList();
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
            return entityList;
        }

        public List<InventoryEntity> GetDataByCondition(InventoryEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public InventoryEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public List<InventoryEntity> GetSkuAll()
        {
            List<InventoryEntity> entityList = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();

                        entityList = DBHelper.SelectStoreProcedure<InventoryEntity>("select_inventory_sku_all").ToList();
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
            return entityList;
        }

        public List<InventoryEntity> GetDataBySku(String sku)
        {
            throw new NotImplementedException();
        }

        public List<InventoryEntity> GetDataBySku(InventoryEntity entity)
        {

            List<InventoryEntity> entityList = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("sku", entity.sku);
                        DBHelper.AddParam("type_id", entity.type_id);

                        entityList = DBHelper.SelectStoreProcedure<InventoryEntity>("select_inventory_by_sku").ToList();
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
            return entityList;
        }

        public List<InventoryEntity> GetDataBySerial(InventoryEntity entity)
        {

            List<InventoryEntity> entityList = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("sku", entity.sku);
                        DBHelper.AddParam("serial", entity.serial);

                        entityList = DBHelper.SelectStoreProcedure<InventoryEntity>("select_inventory_by_serial").ToList();
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
            return entityList;
        }
        public List<InventoryEntity> GetDataByDate(InventoryEntity entity)
        {

            List<InventoryEntity> entityList = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("sku", entity.sku);
                        DBHelper.AddParam("create_date", entity.create_date);

                        entityList = DBHelper.SelectStoreProcedure<InventoryEntity>("select_inventory_by_date").ToList();
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
            return entityList;
        }

        public List<InventoryEntity> CheckDuplicateData(InventoryEntity entity)
        {

            List<InventoryEntity> entityList = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("sku", entity.sku);
                        DBHelper.AddParam("serial", entity.serial);
                        entityList = DBHelper.SelectStoreProcedure<InventoryEntity>("select_inventory_duplicate").ToList();
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
            return entityList;
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
                                    DBHelper.AddParamOut("inventory_id", item.inventory_id);
                                    DBHelper.AddParam("branch_id", item.branch_id);
                                    DBHelper.AddParam("name", item.name);
                                    DBHelper.AddParam("qty", item.qty);
                                    DBHelper.AddParam("qty_total", item.qty_total);
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

        public int UpdateQtyTotle(InventoryEntity entity)
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

                            if (entity.updateMode == entity.OutBound)
                            {
                                foreach (var item in entity.inventoryEntityList)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParam("inventory_id", item.inventory_id);
                                    DBHelper.AddParam("qty_total", item.qty_total);
                                    DBHelper.AddParamOut("inventory_update_id", item.inventory_id);

                                    DBHelper.ExecuteStoreProcedure("update_inventory_outbound");
                                    inventory_id += DBHelper.GetParamOut<Int32>("inventory_update_id");
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
    }
}
