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
        public ICollection<Food> Foods { get; set; } = new List<Food>();
        public bool IsDeleted { get; set; } = false;

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        public string GetFoods()
        {
            return string.Join(", ", Foods.Select(f=>f.Name).ToArray());
        }

        public double GetTotalCalorie()
        {
            return Foods.Sum(f=>f.Calorie);
        }
    }
}
