using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Definitions;
using Entity;

namespace DAO.Entity
{
    public class EntityDAO : IDAORepository<EntityEntity>
    {
        DBHelper DBHelper = null;

        public EntityDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<EntityEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<EntityEntity> GetDataByCondition(EntityEntity entity)
        {
            List<EntityEntity> entityEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();

                        DBHelper.AddParam("Search", entity.entity_name);


                        entityEntities = DBHelper.SelectStoreProcedure<EntityEntity>("select_entity_by_condition").ToList();
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
            return entityEntities;
        }

        public List<EntityEntity> GetDataByCondition(EntityEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public EntityEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(EntityEntity entity)
        {
            Int32 entity_id = 0;
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
                            if (entity.entity_id > 0)
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParam("entity_id", entity.entity_id);
                                DBHelper.AddParam("entity_name", entity.entity_name);
                                DBHelper.AddParam("logo", entity.logo);
                                DBHelper.AddParam("address", entity.address);
                                DBHelper.AddParam("register_address", entity.register_address);
                                DBHelper.AddParam("tax_id", entity.tax_id);
                                DBHelper.AddParam("perfix", entity.perfix);
                                DBHelper.AddParam("phone", entity.phone);
                                DBHelper.AddParam("email", entity.email);
                                DBHelper.AddParam("username", entity.username);
                                DBHelper.AddParam("password", entity.password);
                                DBHelper.AddParam("create_date", entity.create_date);
                                DBHelper.AddParam("modify_date", entity.modify_date);
                                DBHelper.AddParam("is_active", entity.is_active);
                                DBHelper.AddParam("is_delete", entity.is_delete);
                                DBHelper.AddParamOut("success_row", result);

                                DBHelper.ExecuteStoreProcedure("update_entity");
                                entity_id = entity.entity_id;
                            }
                            else
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParamOut("entity_id", entity.entity_id);
                                DBHelper.AddParam("entity_name", entity.entity_name);
                                DBHelper.AddParam("logo", entity.logo);
                                DBHelper.AddParam("address", entity.address);
                                DBHelper.AddParam("register_address", entity.register_address);
                                DBHelper.AddParam("tax_id", entity.tax_id);
                                DBHelper.AddParam("perfix", entity.perfix);
                                DBHelper.AddParam("phone", entity.phone);
                                DBHelper.AddParam("email", entity.email);
                                DBHelper.AddParam("username", entity.username);
                                DBHelper.AddParam("password", entity.password);
                                DBHelper.AddParam("create_date", entity.create_date);
                                DBHelper.AddParam("modify_date", entity.modify_date);
                                DBHelper.AddParam("is_active", entity.is_active);
                                DBHelper.AddParam("is_delete", entity.is_delete);

                                DBHelper.ExecuteStoreProcedure("insert_entity");
                                entity_id = DBHelper.GetParamOut<Int32>("entity_id");
                            }

                            DBHelper.CommitTransaction();
                            result = entity_id;
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

        public int UpdateData(EntityEntity entity)
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
                            DBHelper.CreateParameters();
                            DBHelper.AddParam("entity_id", entity.entity_id);
                            DBHelper.AddParam("entity_name", entity.entity_name);
                            DBHelper.AddParam("logo", entity.logo);
                            DBHelper.AddParam("address", entity.address);
                            DBHelper.AddParam("register_address", entity.register_address);
                            DBHelper.AddParam("tax_id", entity.tax_id);
                            DBHelper.AddParam("perfix", entity.perfix);
                            DBHelper.AddParam("phone", entity.phone);
                            DBHelper.AddParam("email", entity.email);
                            DBHelper.AddParam("username", entity.username);
                            DBHelper.AddParam("password", entity.password);
                            DBHelper.AddParam("create_date", entity.create_date);
                            DBHelper.AddParam("modify_date", entity.modify_date);
                            DBHelper.AddParam("is_active", entity.is_active);
                            DBHelper.AddParam("is_delete", entity.is_delete);
                            DBHelper.AddParamOut("success_row", result);

                            DBHelper.ExecuteStoreProcedure("update_entity");
                            Int32 param_out_id = DBHelper.GetParamOut<Int32>("success_row");

                            DBHelper.CommitTransaction();
                            result = param_out_id;
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

        public EntityEntity GetDataEntityByID(int entity_id)
        {
            EntityEntity entityEntity = new EntityEntity();
            
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("entity_id", entity_id);
                        entityEntity = DBHelper.SelectStoreProcedureFirst<EntityEntity>("select_entity_by_id");                                               
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
            return entityEntity;
        }
    }
}
