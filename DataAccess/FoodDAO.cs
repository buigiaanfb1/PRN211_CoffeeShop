using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BusinessObject.Object;

namespace DataAccess
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetFoods()
        {
            try
            {
                using var context = new QuanLyQuanCafeContext();
                List<Food> allfood = context.Foods.ToList();
                return allfood;
            }
            catch(Exception eX)
            {
                throw new Exception(eX.Message);
            }
        }

        public Food GetFoodByName(string name)
        {
            Food fool = null;
            try
            {
                using var context = new QuanLyQuanCafeContext();
                fool = context.Foods.SingleOrDefault(f => f.Name == name);
                return fool;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddFood(Food food)
        {
            try
            {
                if(GetFoodByName(food.Name) == null)
                {
                    using var context = new QuanLyQuanCafeContext();
                    context.Foods.Add(food);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This food name already have mate, Input other food name");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateFood(Food food, string oldfood)
        {
            try
            {
                Food old = GetFoodByName(oldfood);
                if (old != null)
                {
                    food.Id = old.Id;
                    using var context = new QuanLyQuanCafeContext();
                    context.Foods.Update(food);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This Food name isn't exists");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteFood(string food)
        {
            Food victim = null;
            try
            {
                victim = GetFoodByName(food);
                if (victim != null)
                {
                    using var context = new QuanLyQuanCafeContext();
                    context.Foods.Remove(victim);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This Food name isn't exists");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
