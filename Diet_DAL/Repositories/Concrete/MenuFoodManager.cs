using CalorieProject_DAL.Context;
using CalorieProject_DAL.Repositories.Concrete;
using Diet_Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.Repositories.Concrete
{
    public class MenuFoodManager : BaseManager<MenuFoods>
    {
        public MenuFoodManager(DietDBContext contextDB) : base(contextDB)
        {
            _dbContext = contextDB;
        }
        DietDBContext _dbContext;
    }
}
