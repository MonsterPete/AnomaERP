using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Definitions;
using Entity;

namespace DAO.BedManagement
{
    public class BedInventoryDAO : IDAORepository<InventoryEntity>
    {
        DBHelper DBHelper = null;

        public BedInventoryDAO()
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
            throw new NotImplementedException();
        }

        public int InsertDataMore(List<InventoryEntity> inventoryEntities)
        {
            int result = 0;
            int inventory_id = 0;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        using (DBHelper.BeginTransaction())
                        {

                            foreach (var item in inventoryEntities)
                            {
                                if (item.flag == "New")
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParamOut("bed_inventory_id", item.Bed_inventory_id);
                                    DBHelper.AddParam("inventory_id", item.inventory_id);
                                    DBHelper.AddParam("bed_id", item.Bed_id);
                                    DBHelper.AddParam("qty", item.qty);
                                    DBHelper.AddParam("active", item.Active);
                                    result = DBHelper.ExecuteStoreProcedure("insert_bed_inventory");


                                    DBHelper.CreateParameters();
                                    DBHelper.AddParam("inventory_id", item.inventory_id);
                                    DBHelper.AddParam("qty_total", item.qty_total - item.qty);
                                    DBHelper.AddParamOut("inventory_update_id", item.inventory_id);

                                    DBHelper.ExecuteStoreProcedure("update_inventory_outbound");
                                    inventory_id += DBHelper.GetParamOut<Int32>("inventory_update_id");
                                }
                                else
                                {
                                    inventory_id += 1;
                                }
                            }

                            DBHelper.CommitTransaction();
                            result = inventory_id;
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

        public int InsertDataMore_return(List<InventoryEntity> inventoryEntities)
        {
            int result = 0;
            int inventory_id = 0;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        using (DBHelper.BeginTransaction())
                        {

                            foreach (var item in inventoryEntities)
                            {
                                if (item.flag == "select")
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParam("bed_inventory_id", item.Bed_inventory_id);
                                    result = DBHelper.ExecuteStoreProcedure("update_old_Data_of_bed_inventory");

                                    DBHelper.CreateParameters();
                                    DBHelper.AddParamOut("bed_inventory_id", item.Bed_inventory_id);
                                    DBHelper.AddParam("inventory_id", item.inventory_id);
                                    DBHelper.AddParam("bed_id", item.Bed_id);
                                    DBHelper.AddParam("qty", item.qty - item.qty_return);

                                    if ((item.qty - item.qty_return) > 0)
                                    {
                                        DBHelper.AddParam("active", true);
                                    }
                                    else
                                    {
                                        DBHelper.AddParam("active", false);
                                    }

                                    result = DBHelper.ExecuteStoreProcedure("insert_bed_inventory");


                                    DBHelper.CreateParameters();
                                    DBHelper.AddParam("inventory_id", item.inventory_id);
                                    DBHelper.AddParam("qty_total", item.qty_total + item.qty_return);
                                    DBHelper.AddParamOut("inventory_update_id", item.inventory_id);

                                    DBHelper.ExecuteStoreProcedure("update_inventory_outbound");
                                    inventory_id += DBHelper.GetParamOut<Int32>("inventory_update_id");
                                }
                               
                            }

                            DBHelper.CommitTransaction();
                            result = inventory_id;
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

        public BedCustomerEntity GetDateBedCustomerByBedID(int bed_id)
        {
            BedCustomerEntity bedCustomerEntity = new BedCustomerEntity();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("bed_id", bed_id);
                        bedCustomerEntity = DBHelper.SelectStoreProcedureFirst<BedCustomerEntity>("select_bed_customer_by_bed_id");

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
            return bedCustomerEntity;
        }

        public List<InventoryEntity> GetDateBedInventoryByBedID(int bed_id)
        {
            List<InventoryEntity> inventoryEntities = new List<InventoryEntity>();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("bed_id", bed_id);
                        inventoryEntities = DBHelper.SelectStoreProcedure<InventoryEntity>("select_bed_inventory_by_bed_id").ToList();

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
            return inventoryEntities;
        }
    }
}
