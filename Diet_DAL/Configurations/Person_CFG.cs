using CalorieProject_Models.Concretes;
using CalorieProject_Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieProject_DAL.Configurations
{
    public class Person_CFG : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(x => x.FirstName).HasColumnType("varchar(30)");
            builder.Property(x => x.LastName).HasColumnType("varchar(30)");
            builder.Property(x => x.UserName).HasColumnType("varchar(50)");
            builder.Property(x => x.Password).HasColumnType("varchar(20)");
            builder.Property(x => x.BirthDate).HasColumnType("date");
            builder.Property(x => x.Weight).HasColumnType("float").HasMaxLength(250);

            builder.HasData(
                new Person { PersonID = 1, FirstName = "Emre", LastName = "Bekfilavi", Gender = Gender.Male, Weight = 85.5, BirthDate = new DateTime(1995,10,12), UserStatus = UserStatus.Active, UserType = UserType.Admin, ActivityStatus = ActivityStatus.LightlyActive, UserName = "Admin1", Password = "1234" },

                new Person { PersonID = 2, FirstName = "Barış", LastName = "Erdem", Gender = Gender.Male, Weight = 85.5, BirthDate = new DateTime(1995,05,12) , UserStatus = UserStatus.Active, UserType = UserType.Admin, ActivityStatus = ActivityStatus.LightlyActive, UserName = "Admin2", Password = "12345" },

                new Person { PersonID = 3, FirstName = "Recep", LastName = "Öztuna", Gender = Gender.Male, Weight = 85.5, BirthDate = new DateTime(1995,10,12), UserStatus = UserStatus.Active, UserType = UserType.Admin, ActivityStatus = ActivityStatus.LightlyActive, UserName = "Admin3", Password = "123456" }
                );

        }
    }
}
