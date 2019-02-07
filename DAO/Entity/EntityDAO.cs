using System;
using System.Collections.Generic;
using System.Text;
using Definitions;
using Entity;

namespace DAO.Entity
{
    public class EntityDAO : IDAORepository<EntityEntity>
    {
        DBHelper DBHelper = null;

        public EntityDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<EntityEntity> GetDataAll()
        {
            throw new NotImplementedException();
        }

        public List<EntityEntity> GetDataByCondition(EntityEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<EntityEntity> GetDataByCondition(EntityEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public EntityEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(EntityEntity entity)
        {
            Int32 entity_id = 0;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();
                        DBHelper.AddParamOut("entity_id", entity.entity_id);
                        DBHelper.AddParam("entity_name", entity.entity_name);
                        DBHelper.AddParam("logo", entity.logo);
                        DBHelper.AddParam("address", entity.address);
                        DBHelper.AddParam("register_address", entity.register_address);
                        DBHelper.AddParam("tax_id", entity.tax_id);
                        DBHelper.AddParam("perfix", entity.perfix);
                        DBHelper.AddParam("phone", entity.phone);
                        DBHelper.AddParam("email", entity.email);
                        DBHelper.AddParam("username", entity.username);
                        DBHelper.AddParam("password", entity.password);
                        DBHelper.AddParam("create_date", entity.create_date);
                        DBHelper.AddParam("modify_date", entity.modify_date);
                        DBHelper.AddParam("is_active", entity.is_active);
                        DBHelper.AddParam("is_delete", entity.is_delete);

                        DBHelper.ExecuteStoreProcedure("insert_entity");
                        entity_id = DBHelper.GetParamOut<Int32>("entity_id");
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
            return entity_id;
        }

        public int UpdateData(EntityEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
