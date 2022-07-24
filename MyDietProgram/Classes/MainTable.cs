using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDietProgram.Classes
{
    public class MainTable
    {
        public int UserId { get; set; }
        public int MealId { get; set; }
        public int FoodId { get; set; }
        public double Amount { get; set; }
        public DateTime MealDate { get; set; }
    }
}
