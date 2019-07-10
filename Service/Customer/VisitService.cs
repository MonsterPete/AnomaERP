using DAO.Customer;
using Entity.Customer;
using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Service.Customer
{
    public class VisitService : IServiceRepository<VisitEntity>
    {
        public List<VisitEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<VisitEntity> GetDataByCondition(VisitEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<VisitEntity> GetDataByCondition(VisitEntity entity, int index)
        {
            throw new NotImplementedException();
        }

        public VisitEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public List<VisitEntity> GetDataListByCustomerID(long id)
        {
            VisitDAO visitDAO = new VisitDAO();
            return visitDAO.GetDataByCustomerID(id);
        }

        public int InsertData(VisitEntity entity)
        {
            VisitDAO visitDAO = new VisitDAO();
            return visitDAO.InsertData(entity);
        }

        public int UpdateData(VisitEntity entity)
        {
            VisitDAO visitDAO = new VisitDAO();
            return visitDAO.UpdateData(entity);
        }

        public List<Visit_fileEntity> GetDataVisitFileByVisitorID(int visit_id)
        {
            VisitDAO visitDAO = new VisitDAO();
            return visitDAO.GetDataVisitFileByVisitorID(visit_id);
        }

        public int InsertVisitFile(Visit_fileEntity visit_FileEntity)
        {
            VisitDAO visitDAO = new VisitDAO();
            return visitDAO.InsertVisitFile(visit_FileEntity);
        }

        public int DeleteVisitFile(Visit_fileEntity visit_FileEntity)
        {
            VisitDAO visitDAO = new VisitDAO();
            return visitDAO.DeleteVisitFile(visit_FileEntity);
        }
    }
}
