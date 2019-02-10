using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO.Branch.BranchBuilding
{
    public class BranchFloorDAO : IDAORepository<BranchFloorEntity>
    {
        DBHelper DBHelper = null;

        public BranchFloorDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<BranchFloorEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<BranchFloorEntity> GetDataByCondition(BranchFloorEntity entity)
        {
            List<BranchFloorEntity> branchFloorEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("room_id", entity.branch_id);
                        DBHelper.AddParam("floor_id", entity.floor_id);
                        DBHelper.AddParam("floor_name", entity.floor_name);
                        DBHelper.AddParam("is_active", entity.is_active);
                        branchFloorEntities = DBHelper.SelectStoreProcedure<BranchFloorEntity>("select_branch_floor_by_condition").ToList();
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

            return branchFloorEntities;
        }

        public List<BranchFloorEntity> GetDataByCondition(BranchFloorEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public BranchFloorEntity GetDataByID(long id)
        {
            BranchFloorEntity branchFloorEntities = new BranchFloorEntity();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("branch_id", id);

                        branchFloorEntities = DBHelper.SelectStoreProcedureFirst<BranchFloorEntity>("select_branch_floor_by_id");


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
            return branchFloorEntities;
        }

        public int InsertData(BranchFloorEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(BranchFloorEntity entity)
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
                            DBHelper.AddParam("floor_id", entity.floor_id);                           
                            DBHelper.AddParam("is_active", entity.is_active);                           
                            DBHelper.AddParamOut("success_row", result);

                            DBHelper.ExecuteStoreProcedure("update_branch_floor_active");
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

        public List<BranchFloorEntity> GetDataBranchFloorByID(int Branch_id)
        {
            //BranchFloorEntity branchFloorEntity = new BranchFloorEntity();
            List<BranchFloorEntity> branchFloorEntities = new List<BranchFloorEntity>();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("branch_id", Branch_id);
                        
                        branchFloorEntities = DBHelper.SelectStoreProcedure<BranchFloorEntity>("select_branchfloor_by_branch_id").ToList();

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
            return branchFloorEntities;
        }

        public int InsertDataMore(List<BranchFloorEntity> branchFloorEntity)
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
                                foreach (var item in branchFloorEntity)
                                {
                                    if(item.floor_id > 0)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParam("floor_id", item.floor_id);
                                    DBHelper.AddParam("branch_id", item.branch_id);
                                    DBHelper.AddParam("floor_name", item.floor_name);
                                    DBHelper.AddParam("is_active", item.is_active);
                                    DBHelper.AddParam("is_delete", item.is_delete);
                                    DBHelper.AddParam("create_date", item.create_date);

                                    result = DBHelper.ExecuteStoreProcedure("update_branch_floor");
                                }
                                else
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParamOut("floor_id", item.floor_id);
                                    DBHelper.AddParam("branch_id", item.branch_id);
                                    DBHelper.AddParam("floor_name", item.floor_name);
                                    DBHelper.AddParam("is_active", item.is_active);
                                    DBHelper.AddParam("is_delete", item.is_delete);
                                    DBHelper.AddParam("create_date", item.create_date);

                                    DBHelper.ExecuteStoreProcedure("insert_branch_floor");
                                    result = DBHelper.GetParamOut<Int32>("floor_id");
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
