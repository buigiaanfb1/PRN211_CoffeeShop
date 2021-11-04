using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<FoodCategory> GetCategories() => CategoryDAO.Instance.GetCategories();
    }
}
