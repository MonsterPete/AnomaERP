﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Definitions;
using Entity;


namespace DAO.SiteVisit
{
    public class SiteVisitDAO : IDAORepository<SiteVisitEntity>
    {
        DBHelper DBHelper = null;
        public SiteVisitDAO()
        {
            DBHelper = new DBHelper();
        }


        public List<SiteVisitEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<SiteVisitEntity> GetDataByCondition(SiteVisitEntity entity)
        {
            List<SiteVisitEntity> entityList = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();

                        DBHelper.AddParam("customer_name", entity.sch_customer_name);
                        DBHelper.AddParam("reservation", entity.sch_reservation);
                        DBHelper.AddParam("branch_id", entity.branch_id);

                        entityList = DBHelper.SelectStoreProcedure<SiteVisitEntity>("select_site_visit_by_condition").ToList();
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
            return entityList;
        }

        public List<SiteVisitEntity> GetDataByCondition(SiteVisitEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public SiteVisitEntity GetDataByID(long id)
        {
            SiteVisitEntity entity = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();

                        DBHelper.AddParam("visitor_id", id);

                        entity = DBHelper.SelectStoreProcedure<SiteVisitEntity>("select_site_visit_by_id").ToList()[0];
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
            return entity;
        }

        public int InsertData(SiteVisitEntity entity)
        {
            Int32 visitor_id = 0;
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
                            DBHelper.AddParamOut("visitor_id", entity.visitor_id);
                            DBHelper.AddParam("branch_id", entity.branch_id);
                            DBHelper.AddParam("firstname", entity.firstname);
                            DBHelper.AddParam("lastname", entity.lastname);
                            DBHelper.AddParam("revice_from", entity.revice_from);
                            DBHelper.AddParam("phone", entity.phone);
                            DBHelper.AddParam("comment", entity.comment);
                            DBHelper.AddParam("date_of_visit", entity.date_of_visit);
                            DBHelper.AddParam("date_of_appointment", entity.date_of_appointment);
                            DBHelper.AddParam("price_listed", entity.price_listed);
                            DBHelper.AddParam("symptom", entity.symptom);
                            DBHelper.AddParam("reservation", entity.reservation);

                            DBHelper.ExecuteStoreProcedure("insert_site_visit");
                            visitor_id = DBHelper.GetParamOut<Int32>("visitor_id");


                            DBHelper.CreateParameters();
                            DBHelper.AddParamOut("site_visite_communication_id", entity.visitor_id);
                            DBHelper.AddParam("visitor_id", visitor_id);
                            DBHelper.AddParam("is_facebook", entity.is_facebook);
                            DBHelper.AddParam("is_magazine", entity.is_magazine);
                            DBHelper.AddParam("is_advertise", entity.is_advertise);
                            DBHelper.AddParam("is_youtube", entity.is_youtube);
                            DBHelper.AddParam("is_biilboard", entity.is_biilboard);
                            DBHelper.AddParam("is_recommend", entity.is_recommend);
                            DBHelper.AddParam("is_other", entity.is_other);
                            DBHelper.AddParam("comment_other", entity.comment_other);
                            DBHelper.ExecuteStoreProcedure("insert_site_visite_communication");

                            DBHelper.CommitTransaction();
                            result = visitor_id;
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

        public int UpdateData(SiteVisitEntity entity)
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
                            DBHelper.AddParam("visitor_id", entity.visitor_id);
                            DBHelper.AddParam("branch_id", entity.branch_id);
                            DBHelper.AddParam("firstname", entity.firstname);
                            DBHelper.AddParam("lastname", entity.lastname);
                            DBHelper.AddParam("revice_from", entity.revice_from);
                            DBHelper.AddParam("phone", entity.phone);
                            DBHelper.AddParam("comment", entity.comment);
                            DBHelper.AddParam("date_of_visit", entity.date_of_visit);
                            DBHelper.AddParam("date_of_appointment", entity.date_of_appointment);
                            DBHelper.AddParam("price_listed", entity.price_listed);
                            DBHelper.AddParam("symptom", entity.symptom);
                            DBHelper.AddParam("reservation", entity.reservation);
                            DBHelper.ExecuteStoreProcedure("update_site_visit");
                            result = entity.visitor_id;

                            DBHelper.CreateParameters();
                            DBHelper.AddParam("site_visite_communication_id", entity.site_visite_communication_id);
                            DBHelper.AddParam("visitor_id", entity.visitor_id);
                            DBHelper.AddParam("is_facebook", entity.is_facebook);
                            DBHelper.AddParam("is_magazine", entity.is_magazine);
                            DBHelper.AddParam("is_advertise", entity.is_advertise);
                            DBHelper.AddParam("is_youtube", entity.is_youtube);
                            DBHelper.AddParam("is_biilboard", entity.is_biilboard);
                            DBHelper.AddParam("is_recommend", entity.is_recommend);
                            DBHelper.AddParam("is_other", entity.is_other);
                            DBHelper.AddParam("comment_other", entity.comment_other);

                            if (entity.site_visite_communication_id > 0)
                            {
                                DBHelper.ExecuteStoreProcedure("update_site_visite_communication");
                            }
                            else
                            {
                                DBHelper.ExecuteStoreProcedure("insert_site_visite_communication");
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

        //public int DeleteData(SiteVisitEntity entity)
        //{
        //    int result = 0;

        //    try
        //    {
        //        using (DBHelper.CreateConnection())
        //        {
        //            try
        //            {
        //                DBHelper.OpenConnection();
        //                using (DBHelper.BeginTransaction())
        //                {
        //                    DBHelper.CreateParameters();
        //                    DBHelper.AddParam("visitor_id", entity.visitor_id);

        //                    DBHelper.ExecuteStoreProcedure("update_delete_site_visit");
        //                    result = entity.visitor_id;
        //                    DBHelper.CommitTransaction();
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                throw ex;
        //            }
        //            finally
        //            {
        //                DBHelper.CloseConnection();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return result;
        //}
    }
}
