using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess.Repository
{
    public class FoodRepository : IFoodRepository
    {
        public List<Food> GetFoods() => FoodDAO.Instance.GetFoods();
        public Food GetFoodByName(string name) => FoodDAO.Instance.GetFoodByName(name);
        public void AddFood(Food food) => FoodDAO.Instance.AddFood(food);
        public void UpdateFood(Food food, string oldfood) => FoodDAO.Instance.UpdateFood(food, oldfood);
        public void DeleteFood(string food) => FoodDAO.Instance.DeleteFood(food);
    }
}
