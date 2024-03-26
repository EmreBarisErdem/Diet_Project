using CalorieProject_DAL.Context;
using CalorieProject_DAL.Repositories.Concrete;
using CalorieProject_Models.Concretes;
using CalorieProject_Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.Repositories.Concrete
{
    public class MealManager : BaseManager<Meal>
    {
        public MealManager(DietDBContext contextDB) : base(contextDB)
        {
            _dbContext = contextDB;
        }
        DietDBContext _dbContext;


       


        }
    }
