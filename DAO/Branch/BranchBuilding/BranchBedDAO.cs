using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO.Branch.BranchBuilding
{
    public class BranchBedDAO : IDAORepository<BranchBedEntity>
    {
        DBHelper DBHelper = null;

        public BranchBedDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<BranchBedEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<BranchBedEntity> GetDataByCondition(BranchBedEntity entity)
        {
            List<BranchBedEntity> branchBedEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("bed_id", entity.bed_id);
                        DBHelper.AddParam("room_id", entity.room_id);
                        DBHelper.AddParam("floor_id", entity.floor_id);
                        DBHelper.AddParam("bed_name", entity.bed_name);
                        DBHelper.AddParam("is_active", entity.is_active);
                        branchBedEntities = DBHelper.SelectStoreProcedure<BranchBedEntity>("select_branch_bed_by_condition").ToList();
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

            return branchBedEntities;
        }

        public List<BranchBedEntity> GetDataByCondition(BranchBedEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public BranchBedEntity GetDataByID(long id)
        {
            BranchBedEntity branchBedEntity = new BranchBedEntity();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("room_id", id);

                        branchBedEntity = DBHelper.SelectStoreProcedureFirst<BranchBedEntity>("select_branch_bed_by_id");


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
            return branchBedEntity;
        }

        public int InsertData(BranchBedEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(BranchBedEntity entity)
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
                            DBHelper.AddParam("bed_id", entity.bed_id);
                            DBHelper.AddParam("is_active", entity.is_active);
                            DBHelper.AddParamOut("success_row", result);

                            DBHelper.ExecuteStoreProcedure("update_branch_bed_active");
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

        public List<BranchBedEntity> GetDataBranchBedByID(int room_id)
        {
            //BranchFloorEntity branchFloorEntity = new BranchFloorEntity();
            List<BranchBedEntity> branchBedEntities = new List<BranchBedEntity>();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("room_id", room_id);

                        branchBedEntities = DBHelper.SelectStoreProcedure<BranchBedEntity>("select_branchbed_by_room_id").ToList();
                        
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
            return branchBedEntities;
        }

        public int InsertDataMore(List<BranchBedEntity> branchBedEntities)
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
                            foreach (var item in branchBedEntities)
                            {
                                if (item.bed_id > 0)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParam("room_id", item.room_id);
                                    DBHelper.AddParam("bed_id", item.bed_id);
                                    DBHelper.AddParam("bed_name", item.bed_name);
                                    DBHelper.AddParam("bed_type_id", item.bed_type_id);
                                    DBHelper.AddParam("is_active", item.is_active);
                                    DBHelper.AddParam("is_delete", item.is_delete);
                                    DBHelper.AddParam("create_date", item.create_date);

                                    result = DBHelper.ExecuteStoreProcedure("update_branch_bed");
                                }
                                else
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParamOut("bed_id", item.bed_id);
                                    DBHelper.AddParam("room_id", item.room_id);
                                    DBHelper.AddParam("bed_name", item.bed_name);
                                    DBHelper.AddParam("bed_type_id", item.bed_type_id);
                                    DBHelper.AddParam("is_active", item.is_active);
                                    DBHelper.AddParam("is_delete", item.is_delete);
                                    DBHelper.AddParam("create_date", item.create_date);

                                    DBHelper.ExecuteStoreProcedure("insert_branch_bed");
                                    result = DBHelper.GetParamOut<Int32>("bed_id");
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

        public int DeleteData(BranchBedEntity entity)
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
                            DBHelper.AddParam("bed_id", entity.bed_id);
                            DBHelper.AddParamOut("success_row", result);

                            DBHelper.ExecuteStoreProcedure("update_delete_branch_bed");
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
