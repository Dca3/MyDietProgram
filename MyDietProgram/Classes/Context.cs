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
            Category icecek = new Category() { Id = 10, Name = "İçecek" };
            Category diger = new Category() { Id = 11, Name = "Diğer" };

            modelBuilder.Entity<Category>().HasData(
                et, sebze, meyve, salata, tatli, unlu, bakliyat, meze, kuruyemiş, icecek, diger);
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Info> Infos { get; set; }


    }
}
