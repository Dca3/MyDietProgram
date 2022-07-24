using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDietProgram.Classes
{
    public class Meal
    {
        public int MealId { get; set; }
        public MealName Name { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; } = false;

        
    }
}
