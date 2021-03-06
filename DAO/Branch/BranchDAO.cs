﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Definitions;
using Entity;

namespace DAO.Branch
{
    public class BranchDAO : IDAORepository<BranchEntity>
    {

        DBHelper DBHelper = null;

        public BranchDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<BranchEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<BranchEntity> GetDataByCondition(BranchEntity branchEntity)
        {
            List<BranchEntity> branchEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();

                        DBHelper.AddParam("Search", branchEntity.branch_name);
                       DBHelper.AddParam("entity_id", branchEntity.entity_id);
                        DBHelper.AddParam("is_active", branchEntity.is_active_search);

                        branchEntities = DBHelper.SelectStoreProcedure<BranchEntity>("select_branch_by_condition").ToList();
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
            return branchEntities;
        }

        public List<BranchEntity> GetDataByEntity(int entity_id)
        {
            List<BranchEntity> branchEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();

                        DBHelper.AddParam("entity_id", entity_id);

                        branchEntities = DBHelper.SelectStoreProcedure<BranchEntity>("select_branch_by_entity").ToList();
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
            return branchEntities;
        }

        public List<BuildingTypeEntity> GetDataBuildingTypeAll()
        {
            List<BuildingTypeEntity> buildingTypeEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        buildingTypeEntities = DBHelper.SelectStoreProcedure<BuildingTypeEntity>("select_building_type").ToList();
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
            return buildingTypeEntities;
        }

        public List<BranchEntity> GetDataByCondition(BranchEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public BranchEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(BranchEntity branchEntity)
        {
            Int32 branch_id = 0;
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
                            if (branchEntity.branch_id > 0)
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParam("branch_id", branchEntity.branch_id);
                                DBHelper.AddParam("entity_id", branchEntity.entity_id);
                                DBHelper.AddParam("branch_name", branchEntity.branch_name);                               
                                DBHelper.AddParam("address", branchEntity.address);
                                DBHelper.AddParam("registor_address", branchEntity.registor_address);
                                DBHelper.AddParam("tax_id", branchEntity.tax_id);
                                DBHelper.AddParam("prefix", branchEntity.prefix);
                                DBHelper.AddParam("phone", branchEntity.phone);
                                DBHelper.AddParam("email", branchEntity.email);
                                DBHelper.AddParam("usage_area", branchEntity.usage_area);
                                DBHelper.AddParam("rental_price", branchEntity.rental_price);
                                DBHelper.AddParam("username", branchEntity.username);
                                DBHelper.AddParam("password", branchEntity.password);
                                DBHelper.AddParam("create_date", branchEntity.create_date);
                                DBHelper.AddParam("modify_date", branchEntity.modify_date);
                                DBHelper.AddParam("is_active", branchEntity.is_active);
                                DBHelper.AddParam("is_delete", branchEntity.is_delete);
                                DBHelper.AddParamOut("success_row", result);

                                DBHelper.ExecuteStoreProcedure("update_branch");
                                branch_id = branchEntity.entity_id;
                            }
                            else
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParamOut("branch_id", branchEntity.branch_id);
                                DBHelper.AddParam("entity_id", branchEntity.entity_id);
                                DBHelper.AddParam("branch_name", branchEntity.branch_name);
                                DBHelper.AddParam("address", branchEntity.address);
                                DBHelper.AddParam("registor_address", branchEntity.registor_address);
                                DBHelper.AddParam("tax_id", branchEntity.tax_id);
                                DBHelper.AddParam("prefix", branchEntity.prefix);
                                DBHelper.AddParam("phone", branchEntity.phone);
                                DBHelper.AddParam("email", branchEntity.email);
                                DBHelper.AddParam("building_type_id", branchEntity.building_type_id);
                                DBHelper.AddParam("usage_area", branchEntity.usage_area);
                                DBHelper.AddParam("rental_price", branchEntity.rental_price);
                                DBHelper.AddParam("username", branchEntity.username);
                                DBHelper.AddParam("password", branchEntity.password);
                                DBHelper.AddParam("create_date", branchEntity.create_date);
                                DBHelper.AddParam("modify_date", branchEntity.modify_date);
                                DBHelper.AddParam("is_active", branchEntity.is_active);
                                DBHelper.AddParam("is_delete", branchEntity.is_delete);

                                DBHelper.ExecuteStoreProcedure("insert_branch");
                                branch_id = DBHelper.GetParamOut<Int32>("branch_id");
                            }

                            DBHelper.CommitTransaction();
                            result = branch_id;
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

        public int UpdateData(BranchEntity branchEntity)
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
                            DBHelper.AddParam("branch_id", branchEntity.branch_id);
                            
                            DBHelper.AddParam("branch_name", branchEntity.branch_name);
                            DBHelper.AddParam("address", branchEntity.address);
                            DBHelper.AddParam("registor_address", branchEntity.registor_address);
                            DBHelper.AddParam("tax_id", branchEntity.tax_id);
                            DBHelper.AddParam("prefix", branchEntity.prefix);
                            DBHelper.AddParam("phone", branchEntity.phone);
                            DBHelper.AddParam("email", branchEntity.email);
                            DBHelper.AddParam("building_type_id", branchEntity.building_type_id);
                            DBHelper.AddParam("usage_area", branchEntity.usage_area);
                            DBHelper.AddParam("rental_price", branchEntity.rental_price);
                            DBHelper.AddParam("username", branchEntity.username);
                            DBHelper.AddParam("password", branchEntity.password);
                            DBHelper.AddParam("create_date", branchEntity.create_date);
                            DBHelper.AddParam("modify_date", branchEntity.modify_date);
                            DBHelper.AddParam("is_active", branchEntity.is_active);
                            DBHelper.AddParam("is_delete", branchEntity.is_delete);
                            DBHelper.AddParamOut("success_row", result);

                            DBHelper.ExecuteStoreProcedure("update_branch");
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

        public BranchEntity GetDataBranchByID(int branch_id)
        {
            BranchEntity branchEntity = new BranchEntity();

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("branch_id", branch_id);
                        branchEntity = DBHelper.SelectStoreProcedureFirst<BranchEntity>("select_branch_by_id");
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
            return branchEntity;
        }

        public user_loginEntity GetAlllogin(string username, string password)
        {
            user_loginEntity user_LoginEntity = new user_loginEntity();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();

                        DBHelper.CreateParameters();
                        DBHelper.AddParam("username", username);
                        DBHelper.AddParam("password", password);

                        user_LoginEntity = DBHelper.SelectStoreProcedureFirst<user_loginEntity>("[select_login]");
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
            return user_LoginEntity;
        }

        public user_loginEntity CheckUsernameRepeat(string username, int user_id)
        {
            user_loginEntity user_LoginEntity = new user_loginEntity();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();

                        DBHelper.CreateParameters();
                        DBHelper.AddParam("username", username);
                        DBHelper.AddParam("user_id", user_id);

                        user_LoginEntity = DBHelper.SelectStoreProcedureFirst<user_loginEntity>("select_check_user_password_repeat");
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
            return user_LoginEntity;
        }
    }
}
