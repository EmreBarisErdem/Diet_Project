﻿using CalorieProject_DAL.Context;
using CalorieProject_DAL.Repositories.Concrete;
using CalorieProject_Models.Concretes;
using Diet_Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieProject_BLL.Services
{
    public class FoodServices
    {
        public FoodServices()
        {
            foodManager = new FoodManager(new DietDBContext());
        }
        FoodManager foodManager;


        public List<Food> GetFoodWithWords(string word)
        {
            return foodManager.GetFoodWithWords(word);
        }

        public List<Food> GetAll()
        {
            return foodManager.GetAll();
        }

        public Food GetByID(int id)
        {
            return foodManager.Get(id);
        }

        public bool AddOrUpdate(Food food)
        {
            return foodManager.AddOrUpdate(food);
        }

        public bool IsNameValid(string name)
        {
            Food food = foodManager.GetAll().Where(x => x.Name == name).SingleOrDefault();

            if (food != null)
            {
                return false;
            }
            else
            {
                if (name.All(char.IsLetter))
                {
                    return true;
                }
                return false;
            }




        }



    }
}