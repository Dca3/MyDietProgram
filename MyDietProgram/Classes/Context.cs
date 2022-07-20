using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDietProgram.Classes
{
    public class Context:DbContext
    {

        public Context(DbContextOptions options): base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          

            

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Category> Categories { get; set; }
        

    }
}
