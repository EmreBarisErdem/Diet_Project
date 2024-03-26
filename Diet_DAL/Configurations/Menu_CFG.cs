using CalorieProject_Models.Concretes;
using Diet_Models.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.Configurations
{
    internal class Menu_CFG : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.Property(x => x.MealDate).HasColumnType("datetime");
            builder.Property(x => x.TotalCaloriesByMeal).HasColumnType("integer").HasMaxLength(5000);
        }
    }
}
