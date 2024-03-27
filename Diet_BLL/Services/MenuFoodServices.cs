using CalorieProject_DAL.Context;
using Diet_DAL.Repositories.Concrete;
using Diet_Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_BLL.Services
{
    public class MenuFoodServices
    {
        public MenuFoodServices()
        {
            menuFoodManager = new MenuFoodManager(new DietDBContext());
        }
        MenuFoodManager menuFoodManager;

        public bool AddOrUpdate(MenuFoods menuFood)
        {
            return menuFoodManager.AddOrUpdate(menuFood);
        }
    }
}
