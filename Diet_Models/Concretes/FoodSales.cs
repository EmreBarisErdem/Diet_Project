using CalorieProject_Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_Models.Concretes
{
    
    public class FoodSales : BaseEntity
    {
        public int FoodID { get; set; }
        public string Name { get; set; }
        public int MaxQuantity { get; set; }

    }
}
