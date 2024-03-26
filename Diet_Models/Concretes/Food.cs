using CalorieProject_Models.Abstracts;
using CalorieProject_Models.Concretes;
using CalorieProject_Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_Models.Concretes
{
    public class Food : BaseEntity
    {
        public int FoodID { get; set; }

        public string Name { get; set; }

      
        public int Calories { get; set; }

        public int Quantity { get; set; } = 1;

        public string? PicturePath { get; set; }

        public int Grams { get; set; } = 100;

        public Portion Portion { get; set; } = Portion.Standart;

        [NotMapped]
        public int TotalCalories { get; set; } = 0;





        public int FoodCategoryID { get; set; }

        public virtual FoodCategory? FoodCategory { get; set; }

        public Menu? Menu { get; set; }

        public override string ToString()
        {
            return $"{Quantity}x {Name}, {Portion}, {Calories * Quantity * PortionValue()} Calories";
        }

        private double PortionValue()
        {
            if(Portion is Portion.Double)
            {
                return 2;
            }
            else if(Portion is Portion.Standart)
            {
                return 1;
            }
            else
            {
                return 0.5;
            }
        }


    }
}
