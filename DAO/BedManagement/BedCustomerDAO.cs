using Definitions;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO.BedManagement
{
    public class BedCustomerDAO : IDAORepository<BedCustomerEntity>
    {
        DBHelper DBHelper = null;

        public BedCustomerDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<BedCustomerEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<BedCustomerEntity> GetDataByCondition(BedCustomerEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<BedCustomerEntity> GetDataByCondition(BedCustomerEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public BedCustomerEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(BedCustomerEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateAdmitCustomer(BedCustomerEntity entity)
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
                            DBHelper.AddParam("customer_id", entity.customer_id);
                            DBHelper.AddParam("is_admit", entity.is_admit);
                            DBHelper.AddParam("modify_by", entity.create_by);
                            DBHelper.AddParam("modify_date", entity.create_date);

                            result = DBHelper.ExecuteStoreProcedure("update_admit_customer");
                            if (result > 0)
                            {
                                DBHelper.CommitTransaction();
                            }
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
        public int InsertDataAndUpTBDateBedAndTBCustomer(BedCustomerEntity entity)
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
                            DBHelper.AddParam("customer_id", entity.customer_id);
                            DBHelper.AddParam("bed_id", entity.bed_id);
                            //DBHelper.AddParam("status_bed_id", entity.status_bed_id);
                            DBHelper.AddParam("create_by", entity.create_by);
                            DBHelper.AddParam("create_date", entity.create_date);

                            result = DBHelper.ExecuteStoreProcedure("insert_bed_customer");

                            if (result > 0)
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParam("bed_id", entity.bed_id);
                                DBHelper.AddParam("is_have_customer", true);
                                DBHelper.AddParam("modify_by", entity.create_by);
                                DBHelper.AddParam("modify_date", entity.create_date);

                                result = DBHelper.ExecuteStoreProcedure("update_bed_have_customer");
                                if (result > 0)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParam("customer_id", entity.customer_id);
                                    DBHelper.AddParam("is_have_bed", true);
                                    DBHelper.AddParam("modify_by", entity.create_by);
                                    DBHelper.AddParam("modify_date", entity.create_date);

                                    result = DBHelper.ExecuteStoreProcedure("update_customer_have_bed");
                                }
                            }
                            if (result > 0)
                            {
                                DBHelper.CommitTransaction();
                            }
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

        public int UpdateDeleteDataAndUpDeleteTBDateBedAndTBCustomer(BedCustomerEntity entity)
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
                            DBHelper.AddParam("bed_customer_id", entity.bed_customer_id);
                            DBHelper.AddParam("modify_by", entity.modify_by);
                            DBHelper.AddParam("modify_date", entity.modify_date);

                            result = DBHelper.ExecuteStoreProcedure("update_un_active_bed_customer");

                            if (result > 0)
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParam("bed_id", entity.bed_id);
                                DBHelper.AddParam("is_have_customer", false);
                                DBHelper.AddParam("modify_by", entity.create_by);
                                DBHelper.AddParam("modify_date", entity.create_date);

                                result = DBHelper.ExecuteStoreProcedure("update_bed_have_customer");
                                if (result > 0)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParam("customer_id", entity.customer_id);
                                    DBHelper.AddParam("modify_by", entity.create_by);
                                    DBHelper.AddParam("modify_date", entity.create_date);

                                    result = DBHelper.ExecuteStoreProcedure("update_delete_customer");
                                }
                            }
                            if (result > 0)
                            {
                                DBHelper.CommitTransaction();
                            }
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

        public int UpdateDeleteDataAndUpTBDateBedAndTBCustomer(BedCustomerEntity entity)
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
                            DBHelper.AddParam("bed_customer_id", entity.bed_customer_id);
                            DBHelper.AddParam("modify_by", entity.create_by);
                            DBHelper.AddParam("modify_date", entity.create_date);

                            result = DBHelper.ExecuteStoreProcedure("update_un_active_bed_customer");

                            if (result > 0)
                            {
                                DBHelper.CreateParameters();
                                DBHelper.AddParam("bed_id", entity.bed_id);
                                DBHelper.AddParam("is_have_customer", false);
                                DBHelper.AddParam("modify_by", entity.create_by);
                                DBHelper.AddParam("modify_date", entity.create_date);

                                result = DBHelper.ExecuteStoreProcedure("update_bed_have_customer");
                                if (result > 0)
                                {
                                    DBHelper.CreateParameters();
                                    DBHelper.AddParam("customer_id", entity.customer_id);
                                    DBHelper.AddParam("is_have_bed", false);
                                    DBHelper.AddParam("modify_by", entity.create_by);
                                    DBHelper.AddParam("modify_date", entity.create_date);

                                    result = DBHelper.ExecuteStoreProcedure("update_customer_have_bed");
                                }
                            }
                            if (result > 0)
                            {
                                DBHelper.CommitTransaction();
                            }
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

        public int UpdateData(BedCustomerEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<BedCustomerEntity> SelectBedCustomerForBedEntity(BedCustomerEntity entity)
        {
            List<BedCustomerEntity> bedCustomerEntities = new List<BedCustomerEntity>();
            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParam("branch_name", entity.branch_name);
                        DBHelper.AddParam("floor_name", entity.floor_name);
                        DBHelper.AddParam("customer_name", entity.fullname);
                        bedCustomerEntities = DBHelper.SelectStoreProcedure<BedCustomerEntity>("select_bed_customer_for_bed_entity").ToList();

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
            return bedCustomerEntities;
        }

    }
}
