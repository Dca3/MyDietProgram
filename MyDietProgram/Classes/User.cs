using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDietProgram.Classes
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Weight { get; set; }

        public double Height { get; set; }

        public Gender Gender { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool ? IsAdmin { get; set; }

        public DailyActivity Activity { get; set; }

        public Goal Goal { get; set; }

        
        public ICollection<Meal> Meals { get; set; }=new List<Meal>();









    }
}
