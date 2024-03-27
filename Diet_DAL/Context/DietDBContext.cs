using CalorieProject_Models.Concretes;
using Diet_DAL.Repositories.Concrete;
using Diet_Models.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CalorieProject_DAL.Context
{
    public class DietDBContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<FoodCategory> FoodCategories { get; set; }

        public DbSet<MenuFoods> MenuFoods { get; set; }

        public DbSet<FoodSales> FoodSales { get; set; } // Sorgu İçin Yapılmıştır



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DietProjectDB;Integrated Security=True;Trust Server Certificate=True");

            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
