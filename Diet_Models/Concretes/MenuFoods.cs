using CalorieProject_Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_Models.Concretes
{
    public class MenuFoods : BaseEntity
    {
        public int MenuFoodsID { get; set; }



        public int MenuID { get; set; }
        public  int FoodID { get; set; }

        public  int FoodQuantity { get; set; }

        public Menu? Menu { get; set; }
        public Food? Food { get; set; }

    }
}
