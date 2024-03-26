using CalorieProject_DAL.Context;
using CalorieProject_Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieProject_DAL.Repositories.Concrete
{
    public class FoodCategoryManager : BaseManager<FoodCategory>
    {
        public FoodCategoryManager(DietDBContext contextDB) : base(contextDB)
        {
            _dbContext = contextDB;
        }
        DietDBContext _dbContext;



    }
}
