using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDietProgram.Classes
{
    public class Meal
    {
        public int Id { get; set; }
        public MealName Name { get; set; }
        public DateTime Date { get; set; }



        public ICollection<Food> Foods { get; set; } = new List<Food>();





    }
}
