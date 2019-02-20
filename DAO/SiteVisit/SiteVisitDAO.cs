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
            throw new NotImplementedException();
        }

        public List<SiteVisitEntity> GetDataByCondition(SiteVisitEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public SiteVisitEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
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
                            DBHelper.AddParam("visitor_id", entity.branch_id);
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
                            DBHelper.AddParam("visitor_id", entity.branch_id);
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