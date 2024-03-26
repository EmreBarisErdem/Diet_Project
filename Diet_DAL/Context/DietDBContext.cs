﻿using CalorieProject_Models.Concretes;
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


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=MYDRAGON\\MSSQLSERVER1;Initial Catalog=CalorieDB;Integrated Security=True;Trust Server Certificate=True");

            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
