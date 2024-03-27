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
    public class FoodSalesServices
    {
        public FoodSalesServices()
        {
            foodSalesManager = new FoodSalesManager(new DietDBContext());
        }
        FoodSalesManager foodSalesManager;


        public List<FoodSales> GetFoodAndMaxQuantity()
        {
            return foodSalesManager.GetFoodAndMaxQuantity();
        }
    }
}
