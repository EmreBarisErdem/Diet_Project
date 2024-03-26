using CalorieProject_Models.Abstracts;
using CalorieProject_Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_Models.Concretes
{
    public class Menu : BaseEntity
    {
        public int MenuID { get; set; }

        public int PersonID { get; set; }

        public int MealID { get; set; }

        public int FoodID { get; set; }


        public int? TotalCaloriesByMeal { get; set; }




        public ICollection<Food>? Foods { get; set; }

        public Person? Person { get; set; }

        public ICollection<Meal>? Meals { get; set; }


    }
}
