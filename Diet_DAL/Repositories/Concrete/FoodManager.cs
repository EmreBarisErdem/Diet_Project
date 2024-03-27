using CalorieProject_DAL.Context;
using CalorieProject_Models.Concretes;
using Diet_Models.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            return _dbContext.Foods.Where(x=>x.Name.Contains(word)).ToList();
        }

        public List<MenuFoods> GetFoodFromMenu(int menuID)
        {
            return _dbContext.MenuFoods.Include(x=>x.Food.FoodCategory).Include(x=>x.Menu).Where(x=>x.MenuID == menuID).ToList();
        }
        

        public List<dynamic> GetMaxFoodQuantity()
        {

            var result = _dbContext.Set<object>().FromSqlRaw("SELECT mf.FoodID,f.Name, SUM(f.Quantity) as 'TotalSales'\r\nFROM Menus m INNER JOIN MenuFoods mf  ON mf.MenuID = m.MenuID\r\nINNER JOIN Foods f ON f.FoodID = mf.FoodID\r\nGROUP BY mf.FoodID,f.Name\r\nORDER BY 'TotalSales' DESC").ToList();

            return result;
        }
    }
}
