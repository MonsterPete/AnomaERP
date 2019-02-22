using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using DAO.Category;

namespace Service.Category
{
    public class CategoryService : IServiceRepository<CategoryEntity>
    {
        public List<CategoryEntity> GetDataAll()
        {
            CategoryDAO dao = new CategoryDAO();
            return dao.GetDataAll();
        }

        public List<CategoryEntity> GetDataByCondition(CategoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<CategoryEntity> GetDataByCondition(CategoryEntity entity, int index)
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
