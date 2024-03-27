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
    public class FoodSales_CFG : IEntityTypeConfiguration<FoodSales>
    {
        public void Configure(EntityTypeBuilder<FoodSales> builder)
        {
            builder.HasNoKey();
        }
    }
}
