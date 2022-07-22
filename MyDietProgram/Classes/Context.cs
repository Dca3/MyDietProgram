using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDietProgram.Classes
{
    public class Context : DbContext
    {
        private readonly ModelBuilder _modelBuilder;

        public Context(DbContextOptions options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            Category et = new Category() { Id = 1, Name = "Et" };
            Category sebze = new Category() { Id = 2, Name = "Sebze" };
            Category meyve = new Category() { Id = 3, Name = "Meyve" };
            Category salata = new Category() { Id = 4, Name = "Salata" };
            Category tatli = new Category() { Id = 5, Name = "Tatlı" };
            Category unlu = new Category() { Id = 6, Name = "Unlu Mamül" };
            Category bakliyat = new Category() { Id = 7, Name = "Bakliyat" };
            Category meze = new Category() { Id = 8, Name = "Meze" };
            Category kuruyemiş = new Category() { Id = 9, Name = "Kuruyemiş" };

            modelBuilder.Entity<Category>().HasData(
                et, sebze, meyve, salata, tatli, unlu, bakliyat, meze, kuruyemiş);

            modelBuilder.Entity<Food>().HasData(
                new Food() { Id = 1, Name = "Ali nazik", Category = meze },
                new Food() { Id = 2, Name = "İskender", Category = et },
                new Food() { Id = 3, Name = "Hamburger", Category = et },
                new Food() { Id = 4, Name = "Çoban salata", Category = salata },
                new Food() { Id = 5, Name = "Balık", Category = et },
                new Food() { Id = 6, Name = "Kuru fasülye", Category = bakliyat },
                new Food() { Id = 7, Name = "Dondurma", Category = tatli },
                new Food() { Id = 8, Name = "Pilav", Category = bakliyat },
                new Food() { Id = 9, Name = "Domates", Category = sebze },
                new Food() { Id = 10, Name = "Salatalık", Category = sebze },
                new Food() { Id = 11, Name = "Elma", Category = meyve },
                new Food() { Id = 12, Name = "Armut", Category = meyve },
                new Food() { Id = 13, Name = "Muz", Category = meyve },
                new Food() { Id = 14, Name = "Yulaf", Category = meyve }
            );

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Category> Categories { get; set; }


    }
}
