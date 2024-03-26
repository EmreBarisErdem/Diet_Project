using CalorieProject_Models.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieProject_DAL.Configurations
{
    public class FoodCategories_CFG : IEntityTypeConfiguration<FoodCategory>
    {
        public void Configure(EntityTypeBuilder<FoodCategory> builder)
        {
            builder.Property(x => x.FoodCategoryName).HasColumnType("varchar(30)");

            builder.HasData(
                new FoodCategory { FoodCategoryID = 1, FoodCategoryName = "Fruits" },
                new FoodCategory { FoodCategoryID = 2, FoodCategoryName = "Vegetables" },
                new FoodCategory { FoodCategoryID = 3, FoodCategoryName = "FastFoods" },
                new FoodCategory { FoodCategoryID = 4, FoodCategoryName = "Cheeses" },
                new FoodCategory { FoodCategoryID = 5, FoodCategoryName = "Meats" },
                new FoodCategory { FoodCategoryID = 6, FoodCategoryName = "Sweets" },
                new FoodCategory { FoodCategoryID = 7, FoodCategoryName = "Beverages" },
                new FoodCategory { FoodCategoryID = 8, FoodCategoryName = "Cereals" },
                new FoodCategory { FoodCategoryID = 9, FoodCategoryName = "Legumes" },
                new FoodCategory { FoodCategoryID = 10, FoodCategoryName = "Edible oils and fats" },
                new FoodCategory { FoodCategoryID = 11, FoodCategoryName = "Milk and milk products" },
                new FoodCategory { FoodCategoryID = 12, FoodCategoryName = "Others" }
                
            );
        }
    }
}
