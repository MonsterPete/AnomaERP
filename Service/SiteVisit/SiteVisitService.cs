using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAO.SiteVisit;

namespace Service.SiteVisit
{
    public class SiteVisitService : IServiceRepository<SiteVisitEntity>
    {
        public List<SiteVisitEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<SiteVisitEntity> GetDataByCondition(SiteVisitEntity entity)
        {
            SiteVisitDAO siteVisitDAO = new SiteVisitDAO();
            return siteVisitDAO.GetDataByCondition(entity);
        }

        public List<SiteVisitEntity> GetDataByCondition(SiteVisitEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public SiteVisitEntity GetDataByID(long id)
        {
            SiteVisitDAO siteVisitDAO = new SiteVisitDAO();
            return siteVisitDAO.GetDataByID(id);
        }

        public int InsertData(SiteVisitEntity entity)
        {
            SiteVisitDAO siteVisitDAO = new SiteVisitDAO();
            return siteVisitDAO.InsertData(entity);
        }

        public int UpdateData(SiteVisitEntity entity)
        {
            SiteVisitDAO siteVisitDAO = new SiteVisitDAO();
            return siteVisitDAO.UpdateData(entity);
        }
        //public int DeleteData(SiteVisitEntity entity)
        //{
        //    SiteVisitDAO siteVisitDAO = new SiteVisitDAO();
        //    return siteVisitDAO.DeleteData(entity);
        //}
    }
}
