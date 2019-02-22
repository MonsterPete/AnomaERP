using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Definitions;
using Entity;

namespace DAO.Category
{
    public class CategoryDAO : IDAORepository<CategoryEntity>
    {
        DBHelper DBHelper = null;
        public CategoryDAO()
        {
            DBHelper = new DBHelper();
        }

        public List<CategoryEntity> GetDataAll()
        {
            List<CategoryEntity> entityList = null;

            try
            {
                using (DBHelper.CreateConnection())
                {
                    try
                    {
                        DBHelper.OpenConnection();
                        DBHelper.CreateParameters();

                        entityList = DBHelper.SelectStoreProcedure<CategoryEntity>("select_category_all").ToList();
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

        public List<CategoryEntity> GetDataByCondition(CategoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<CategoryEntity> GetDataByCondition(CategoryEntity entity, int Index)
        {
            throw new NotImplementedException();
        }

        public CategoryEntity GetDataByID(long id)
        {
            throw new NotImplementedException();
        }

        public int InsertData(CategoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(CategoryEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
