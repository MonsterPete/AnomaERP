using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Definitions;
using Entity;

namespace DAO.Role
{
    public class EntityTaskDAO : IDAORepository<EntityTaskEntity>
    {
        DBHelper DBHelper = null;

        public EntityTaskDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<EntityTaskEntity> GetDataAll()
        {
            List<EntityTaskEntity> entityTaskEntities = new List<EntityTaskEntity>();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        entityTaskEntities = DBHelper.SelectStoreProcedure<EntityTaskEntity>("select_all_entity_task").ToList();
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
            return entityTaskEntities;
        }

        public List<EntityTaskEntity> GetDataByCondition(EntityTaskEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<EntityTaskEntity> GetDataByCondition(EntityTaskEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public EntityTaskEntity GetDataByID(long id)
        {
            EntityTaskEntity entityTaskEntity = new EntityTaskEntity();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("group_id", id);

                        entityTaskEntity = DBHelper.SelectStoreProcedureFirst<EntityTaskEntity>("select_task_by_group_id");


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
            return entityTaskEntity;
        }

        public List<EntityTaskEntity> GetDataByGroupID(int id)
        {
            List<EntityTaskEntity> entityTaskEntities = new List<EntityTaskEntity>();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("group_id", id);

                        entityTaskEntities = DBHelper.SelectStoreProcedure<EntityTaskEntity>("select_task_by_group_id").ToList();


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
            return entityTaskEntities;
        }

        public int InsertData(EntityTaskEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(EntityTaskEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<EntityTaskEntity> GetDataTaskByID(int Group_id)
        {
            List<EntityTaskEntity> entityTaskEntities = new List<EntityTaskEntity>();


            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("group_id", Group_id);
                        entityTaskEntities = DBHelper.SelectStoreProcedure<EntityTaskEntity>("select_task_by_group_id").ToList();

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
            return entityTaskEntities;
        }

        public int InsertDataMore(List<EntityTaskEntity> entityTaskEntities)
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
                            foreach (var item in entityTaskEntities)
                            {
                                if (item.task_id > 0)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParam("task_name", item.task_name);
                                    DBHelper.AddParam("task_id", item.task_id);
                                    result = DBHelper.ExecuteStoreProcedure("update_entity_task");

                                }
                                else
                                {
                                   
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParamOut("task_id", item.task_id);
                                    DBHelper.AddParam("task_name", item.task_name);
                                    DBHelper.AddParam("description", item.description);
                                    DBHelper.AddParam("group_id", item.group_id);
                                    DBHelper.AddParam("entity_id", item.entity_id);
                                    DBHelper.AddParam("create_by", item.create_by);
                                    DBHelper.AddParam("create_date", item.create_date);
                                    DBHelper.AddParam("modify_by", item.modify_by);
                                    DBHelper.AddParam("modify_date", item.modify_date);
                                    DBHelper.ExecuteStoreProcedure("insert_entity_task");
                                    result = DBHelper.GetParamOut<Int32>("task_id");
                                    
                                }
                            }

                            DBHelper.CommitTransaction();
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
