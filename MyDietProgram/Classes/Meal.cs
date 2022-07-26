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
        public bool IsDeleted { get; set; } = false;

        public string GetMealName()
        {
            switch (Name)
            {
                case MealName.ÖğleYemeği:
                    return "Öğle yemeği";
                    break;
                case MealName.AkşamYemeği:
                    return "Akşam yemeği";
                    break;
                default:
                    return Name.ToString();
            }
        }
    }
}
