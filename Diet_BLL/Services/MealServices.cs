using CalorieProject_DAL.Context;
using CalorieProject_Models.Concretes;
using Diet_DAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_BLL.Services
{
    public class MealServices
    {

        public MealServices()
        {
            mealManager = new MealManager(new DietDBContext());
        }

        MealManager mealManager;

        public List<Meal> GetMeals()
        {
            return mealManager.GetAll();
        }

        public bool Update(int mealID)
        {
            return mealManager.Update(mealID);
        }

        public Meal GetMealByID(int id)
        {
            return mealManager.Get(id);
        }



    }
    
}
