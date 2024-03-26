using CalorieProject_Models.Abstracts;
using Diet_Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieProject_Models.Concretes
{
    public class Meal : BaseEntity
    {
        public int MealID { get; set; }

        public DateTime MealDate { get; set; }

        public string MealName { get; set; }

       


        public Menu? Menu { get; set; }



    }
}
