using CalorieProject_DAL.Context;
using CalorieProject_DAL.Repositories.Concrete;
using Diet_Models.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.Repositories.Concrete
{
    public class FoodSalesManager : BaseManager<FoodSales>
    {
        public FoodSalesManager(DietDBContext contextDB) : base(contextDB)
        {
            _dbContext = contextDB;
        }
        DietDBContext _dbContext;

        public List<FoodSales> GetFoodAndMaxQuantity()
        {
            return _dbContext.FoodSales.FromSqlRaw("SELECT mf.FoodID,f.Name, SUM(f.Quantity) as 'MaxQuantity'\r\nFROM Menus m INNER JOIN MenuFoods mf  ON mf.MenuID = m.MenuID\r\nINNER JOIN Foods f ON f.FoodID = mf.FoodID\r\nGROUP BY mf.FoodID,f.Name\r\nORDER BY 'MaxQuantity' DESC").ToList();
        }
    }
}
