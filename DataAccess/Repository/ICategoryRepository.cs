using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess.Repository
{
    public interface ICategoryRepository
    {
        List<FoodCategory> GetCategories();
    }
}
