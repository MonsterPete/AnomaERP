using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Definitions;
using Entity;

namespace DAO.EntityTask
{
    public class EntityTaskDAO : IDAORepository<EntityTaskEntity>
    {
        DBHelper DBHelper = null;

        public EntityTaskDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<EntityTaskEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<EntityTaskEntity> GetDataByCondition(EntityTaskEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<EntityTaskEntity> GetDataByCondition(EntityTaskEntity entity, int Index)
        {
            throw new NotImplementedException();
        }
        public List<EntityTaskEntity> GetDataByEmployee(int employeeID)
        {
            List<EntityTaskEntity> entityEntities = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();

                        DBHelper.AddParam("employee_id", employeeID);
                        
                        entityEntities = DBHelper.SelectStoreProcedure<EntityTaskEntity>("select_entity_task_by_employee").ToList();
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
            return entityEntities;
        }
        
        public EntityTaskEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(EntityTaskEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(EntityTaskEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
