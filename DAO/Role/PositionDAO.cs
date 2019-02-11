using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Definitions;
using Entity;

namespace DAO.Role
{
    public class PositionDAO : IDAORepository<PositionEntity>
    {
        DBHelper DBHelper = null;

        public PositionDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<PositionEntity> GetDataAll()
        {
            List<PositionEntity> positionEntities = new List<PositionEntity>();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();

                        positionEntities = DBHelper.SelectStoreProcedure<PositionEntity>("select_all_position").ToList();

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
            return positionEntities;
        }

        public List<PositionEntity> GetDataByCondition(PositionEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<PositionEntity> GetDataByCondition(PositionEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public PositionEntity GetDataByID(long id)
        {
            PositionEntity positionEntity = new PositionEntity();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("group_id", id);

                        positionEntity = DBHelper.SelectStoreProcedureFirst<PositionEntity>("select_position_by_group_id");


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
            return positionEntity;
        }

        public List<PositionEntity> GetDataPositionGroupByID(int Group_id)
        {
            List<PositionEntity> positionEntities = new List<PositionEntity>();


            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("group_id", Group_id);

                        positionEntities = DBHelper.SelectStoreProcedure<PositionEntity>("select_position_by_group_id").ToList();

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
            return positionEntities;
        }

        public int InsertData(PositionEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(PositionEntity entity)
        {
            throw new NotImplementedException();
        }

        public int InsertDataMore(List<PositionEntity> positionEntities)
        {
            int result = 0;
            int result_group_id = 0;
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();

                        using (DBHelper.BeginTransaction())
                        {
                            foreach (var item in positionEntities)
                            {
                                if (item.position_id > 0)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParam("position_name", item.position_name);
                                    DBHelper.AddParam("position_id", item.position_id);                                   
                                    result = DBHelper.ExecuteStoreProcedure("update_position");

                                }
                                else
                                {
                                    if (item.group_id > 0)
                                    {

                                        DBHelper.CreateParameters();
                                        DBHelper.AddParamOut("position_id", item.position_id);
                                        DBHelper.AddParam("group_id", item.group_id);
                                        DBHelper.AddParam("position_name", item.position_name);
                                        DBHelper.AddParam("create_by", item.create_by);
                                        DBHelper.AddParam("create_date", item.create_date);
                                        DBHelper.AddParam("is_active", item.is_active);
                                        DBHelper.AddParam("is_delete", item.is_delete);
                                        DBHelper.ExecuteStoreProcedure("insert_position");
                                        result = DBHelper.GetParamOut<Int32>("position_id");

                                        DBHelper.CreateParameters();
                                        DBHelper.AddParam("position_id", result);
                                        DBHelper.AddParam("create_by", item.create_by);
                                        DBHelper.AddParam("create_date", item.create_date);
                                        DBHelper.AddParam("is_active", item.is_active);
                                        DBHelper.AddParam("is_delete", item.is_delete);
                                        DBHelper.ExecuteStoreProcedure("insert_task_group");
                                    }
                                    else
                                    {
                                        if(result_group_id == 0)
                                        { 
                                        DBHelper.CreateParameters();
                                        DBHelper.AddParamOut("group_id", item.group_id);
                                        DBHelper.AddParam("group_name", item.group_name);
                                        DBHelper.AddParam("create_by", item.create_by);
                                        DBHelper.AddParam("create_date", item.create_date);
                                        DBHelper.AddParam("is_active", item.is_active);
                                        DBHelper.AddParam("is_delete", item.is_delete);
                                        DBHelper.ExecuteStoreProcedure("insert_position_group");
                                        result_group_id = DBHelper.GetParamOut<Int32>("group_id");
                                        }

                                        
                                        DBHelper.CreateParameters();
                                        DBHelper.AddParamOut("position_id", item.position_id);
                                        DBHelper.AddParam("group_id", result_group_id);
                                        DBHelper.AddParam("position_name", item.position_name);
                                        DBHelper.AddParam("create_by", item.create_by);
                                        DBHelper.AddParam("create_date", item.create_date);
                                        DBHelper.AddParam("is_active", item.is_active);
                                        DBHelper.AddParam("is_delete", item.is_delete);
                                        DBHelper.ExecuteStoreProcedure("insert_position");
                                        int position = DBHelper.GetParamOut<Int32>("position_id");

                                        DBHelper.CreateParameters();
                                        DBHelper.AddParam("position_id", position);
                                        DBHelper.AddParam("create_by", item.create_by);
                                        DBHelper.AddParam("create_date", item.create_date);
                                        DBHelper.AddParam("is_active", item.is_active);
                                        DBHelper.AddParam("is_delete", item.is_delete);
                                        DBHelper.ExecuteStoreProcedure("insert_task_group");
                                        
                                    }                                    
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
