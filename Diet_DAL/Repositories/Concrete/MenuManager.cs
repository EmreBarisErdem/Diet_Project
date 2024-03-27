using CalorieProject_DAL.Context;
using CalorieProject_DAL.Repositories.Concrete;
using CalorieProject_Models.Enums;
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


        public List<Menu> GetWeeklyMeals(Weeks selectedWeek, int personID)
        {
            if (selectedWeek is Weeks.FirstWeek)
            {
                return _dbContext.Menus
                    .Where(x => (x.MealDate.Day > 0 && x.MealDate.Day <= 7) && x.PersonID == personID).ToList();

            }
            else if (selectedWeek is Weeks.SecondWeek)
            {

                return _dbContext.Menus
                     .Include(x => x.Person)
                     .Where(x => (x.MealDate.Day > 7 && x.MealDate.Day <= 14) && x.PersonID == personID).ToList();
            }
            else if (selectedWeek is Weeks.ThirdWeek)
            {
                return _dbContext.Menus
                    .Include(x => x.Person)
                    .Where(x => (x.MealDate.Day > 14 && x.MealDate.Day <= 21) && x.PersonID == personID).ToList();
            }
            else
            {
                return _dbContext.Menus
                    .Include(x => x.Person)
                    .Where(x => (x.MealDate.Day > 21 && x.MealDate.Day <= 31) && x.PersonID == personID).ToList();
            }
            // Kalori Çekilip Bunun Toplamı vs İçin Method Yazılacak

        }

        public List<Menu> GetMenusForPeople(int personID)
        {
            return _dbContext.Menus.Include(x => x.Meal).Where(x => x.PersonID == personID && x.MealDate.Day == DateTime.Now.Day).ToList();
        }

        public List<Menu> GetMonthlyMeals(DateTime selectedMonth, int personID)
        {
            return _dbContext.Menus
                .Where(x => (x.MealDate.Month == selectedMonth.Month) && x.PersonID == personID)
                .ToList();
        }

   
    }

}
