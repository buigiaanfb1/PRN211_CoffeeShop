using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess.Repository
{
    public interface IFoodRepository
    {
        List<Food> GetFoods();
        Food GetFoodByName(string name);
        void AddFood(Food food);
        void UpdateFood(Food food, string oldfood);
        void DeleteFood(string food);

    }
}
