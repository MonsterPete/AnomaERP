using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Definitions;
using Entity;

namespace DAO.Role
{
    public class PositionGroupDAO : IDAORepository<PositionGroupEntity>
    {
        DBHelper DBHelper = null;

        public PositionGroupDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<PositionGroupEntity> GetDataAll()
        {
            List<PositionGroupEntity> positionGroupEntities = new List<PositionGroupEntity>();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();

                        positionGroupEntities = DBHelper.SelectStoreProcedure<PositionGroupEntity>("select_all_position_group").ToList();

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
            return positionGroupEntities;
        }

        public List<PositionGroupEntity> GetDataByCondition(PositionGroupEntity entity)
        {
            List<PositionGroupEntity> positionGroupEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();

                        DBHelper.AddParam("Search", entity.group_name);
                        DBHelper.AddParam("entity_id", entity.entity_id);


                        positionGroupEntities = DBHelper.SelectStoreProcedure<PositionGroupEntity>("select_position_group_by_condition").ToList();
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
            return positionGroupEntities;
        }

        public List<PositionGroupEntity> GetDataByCondition(PositionGroupEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public PositionGroupEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(PositionGroupEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(PositionGroupEntity entity)
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
                            DBHelper.AddParam("group_id", entity.group_id);
                            DBHelper.AddParam("is_active", entity.is_active);                           
                            DBHelper.AddParamOut("success_row", result);

                            DBHelper.ExecuteStoreProcedure("update_position_group_active");
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
    }
}
