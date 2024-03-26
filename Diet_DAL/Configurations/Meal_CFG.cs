using CalorieProject_Models.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieProject_DAL.Configurations
{
    public class Meal_CFG : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.Property(x => x.MealName).HasColumnType("varchar(30)");
            

            builder.HasData(new Meal { MealID = 1, MealName = "Breakfast" });
            builder.HasData(new Meal { MealID = 2, MealName = "Lunch" });
            builder.HasData(new Meal { MealID = 3, MealName = "Dinner" });

        }
    }
}
