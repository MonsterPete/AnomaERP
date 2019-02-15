using Definitions;
using Entity.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO.Status
{
    class StatusBedDAO : IDAORepository<StatusBedEntity>
    {
        DBHelper DBHelper = null;

        public StatusBedDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<StatusBedEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<StatusBedEntity> GetDataByCondition(StatusBedEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<StatusBedEntity> GetDataByCondition(StatusBedEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public StatusBedEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(StatusBedEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(StatusBedEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<StatusBedEntity> GetDDLCustomerForAssginBed(StatusBedEntity branchEntity)
        {
            List<StatusBedEntity> statusBedEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();

                        statusBedEntities = DBHelper.SelectStoreProcedure<StatusBedEntity>("ddl_status_bed").ToList();
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
            return statusBedEntities;
        }
    }
}
