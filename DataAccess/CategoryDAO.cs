using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }

        public List<FoodCategory> GetCategories()
        {
            try
            {
                using var context = new QuanLyQuanCafeContext();
                List<FoodCategory> allfood = context.FoodCategories.ToList();
                return allfood;
            }
            catch (Exception eX)
            {
                throw new Exception(eX.Message);
            }
        }
    }
}
