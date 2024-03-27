using CalorieProject_DAL.Context;
using CalorieProject_Models.Concretes;
using Diet_Models.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieProject_DAL.Repositories.Concrete
{
    public class FoodManager : BaseManager<Food>
    {
        public FoodManager(DietDBContext contextDB) : base(contextDB)
        {
            _dbContext = contextDB;
        }

        DietDBContext _dbContext;

        public List<Food> GetFoodWithWords(string word)
        {
            return _dbContext.Foods.Where(x=>x.Name.StartsWith(word)).ToList();
        }

        public List<MenuFoods> GetFoodFromMenu(int menuID)
        {
            return _dbContext.MenuFoods.Include(x=>x.Food.FoodCategory).Include(x=>x.Menu).Where(x=>x.MenuID == menuID).ToList();
        }

    }
}
