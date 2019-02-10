using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO.Branch.BranchBuilding
{
    public class BranchRoomDAO : IDAORepository<BranchRoomEntity>
    {
        DBHelper DBHelper = null;

        public BranchRoomDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<BranchRoomEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<BranchRoomEntity> GetDataByCondition(BranchRoomEntity entity)
        {
            List<BranchRoomEntity> branchRoomEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("room_id", entity.room_id);
                        DBHelper.AddParam("floor_id", entity.floor_id);
                        DBHelper.AddParam("room_name", entity.room_name);
                        DBHelper.AddParam("is_active", entity.is_active);
                        branchRoomEntities = DBHelper.SelectStoreProcedure<BranchRoomEntity>("select_branch_room_by_condition").ToList();
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

            return branchRoomEntities;
        }

        public List<BranchRoomEntity> GetDataByCondition(BranchRoomEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public BranchRoomEntity GetDataByID(long id)
        {
            BranchRoomEntity branchRoomEntity = new BranchRoomEntity();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("floor_id", id);

                        branchRoomEntity = DBHelper.SelectStoreProcedureFirst<BranchRoomEntity>("select_branch_room_by_id");


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
            return branchRoomEntity;
        }

        public int InsertData(BranchRoomEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(BranchRoomEntity entity)
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
                            DBHelper.AddParam("room_id", entity.room_id);
                            DBHelper.AddParam("is_active", entity.is_active);
                            DBHelper.AddParamOut("success_row", result);

                            DBHelper.ExecuteStoreProcedure("update_branch_room_active");
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

        public List<BranchRoomEntity> GetDataBranchRoomByID(int Floor_id)
        {
            //BranchFloorEntity branchFloorEntity = new BranchFloorEntity();
            List<BranchRoomEntity> branchRoomEntities = new List<BranchRoomEntity>();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("floor_id", Floor_id);

                        branchRoomEntities = DBHelper.SelectStoreProcedure<BranchRoomEntity>("select_branchroom_by_floor_id").ToList();

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
            return branchRoomEntities;
        }

        public int InsertDataMore(List<BranchRoomEntity> branchRoomEntities)
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
                            foreach (var item in branchRoomEntities)
                            {
                                if (item.room_id > 0)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParam("floor_id", item.floor_id);
                                    DBHelper.AddParam("room_id", item.room_id);
                                    DBHelper.AddParam("room_name", item.room_name);
                                    DBHelper.AddParam("is_active", item.is_active);
                                    DBHelper.AddParam("is_delete", item.is_delete);
                                    DBHelper.AddParam("create_date", item.create_date);

                                    result = DBHelper.ExecuteStoreProcedure("update_branch_room");
                                }
                                else
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParamOut("room_id", item.room_id);
                                    DBHelper.AddParam("floor_id", item.floor_id);
                                    DBHelper.AddParam("room_name", item.room_name);
                                    DBHelper.AddParam("is_active", item.is_active);
                                    DBHelper.AddParam("is_delete", item.is_delete);
                                    DBHelper.AddParam("create_date", item.create_date);

                                    DBHelper.ExecuteStoreProcedure("insert_branch_room");
                                    result = DBHelper.GetParamOut<Int32>("room_id");
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
