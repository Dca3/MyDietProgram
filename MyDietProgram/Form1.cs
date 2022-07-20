using Microsoft.EntityFrameworkCore;
using MyDietProgram.Classes;

namespace MyDietProgram
{
    public partial class Form1 : Form
    {
        Context db;
        

        public Form1(Classes.Context context)
        {
           this.db=context;
            db.Users.Add(new User() { FirstName = "doðan can", LastName = "Arýcý", Email = "dgncn33@gmail.com",Activity=DailyActivity.Less_Active,Goal=Goal.Gaining_Weigth,Weight=92,Height=192,Gender=Gender.Man });
            db.SaveChanges();

            var a = db.Users.FirstOrDefault();
            InitializeComponent();

            
        }
    }
}