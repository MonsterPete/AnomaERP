﻿using DAO.Customer;
using Entity.Customer;
using System;
using System.Collections.Generic;
using System.Text;

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
            throw new NotImplementedException();
        }
    }
}
