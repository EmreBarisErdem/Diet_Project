using CalorieProject_Models.Abstracts;
using Diet_Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieProject_Models.Concretes
{
    public class FoodCategory : BaseEntity
    {
        public int FoodCategoryID { get; set; }

        public string FoodCategoryName { get; set; }

        public virtual ICollection<Food>? Foods { get; set; }
    }
}
