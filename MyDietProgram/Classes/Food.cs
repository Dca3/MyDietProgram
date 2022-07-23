using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDietProgram.Classes
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Calorie { get; set; }

        public int? Amount { get; set; }

        public string AmountDescription { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey("Meal")]
        public int MealId { get; set; }

        public Meal Meal { get; set; }

        public override string ToString()
        {
            return $"{Name} ({AmountDescription}, {Calorie} kcal)";
        }
    }
}
