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
    public class MenuManager : BaseManager<Menu>
    {
        public MenuManager(DietDBContext contextDB) : base(contextDB)
        {
            _dbContext = contextDB;
        }
        DietDBContext _dbContext;


    }
}
