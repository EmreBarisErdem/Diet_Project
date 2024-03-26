using CalorieProject_DAL.Repositories.Concrete;
using CalorieProject_Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieProject_BLL.Services
{
    public class FoodCategoryServices
    {
        public FoodCategoryServices()
        {
            foodCategoryManager = new FoodCategoryManager(new CalorieProject_DAL.Context.DietDBContext());
        }
        FoodCategoryManager foodCategoryManager;

        public List<FoodCategory> GetAll()
        {
            return foodCategoryManager.GetAll();
        }

        public FoodCategory GetByID(int id)
        {
            return foodCategoryManager.Get(id);
        }
    }
}
