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
        public int FoodId { get; set; }
        public string Name { get; set; }

        public int Calorie { get; set; }

        public double? Amount { get; set; }

        public string AmountDescription { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return $"{Name} ({AmountDescription}, {Calorie} kcal)";
        }
    }
}
