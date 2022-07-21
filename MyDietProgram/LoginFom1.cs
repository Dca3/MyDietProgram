using Microsoft.EntityFrameworkCore;
using MyDietProgram.Classes;

namespace MyDietProgram
{
    public partial class LoginFom1 : Form
    {
        Context db;
        

        public LoginFom1(Classes.Context context)
        {
           //this.db=context;
           // db.Users.Add(new User() { FirstName = "doðan can", LastName = "Arýcý", Email = "dgncn33@gmail.com",Activity=DailyActivity.Less_Active,Goal=Goal.Gaining_Weigth,Weight=92,Height=192,Gender=Gender.Man });
           // db.SaveChanges();

           // var a = db.Users.FirstOrDefault();
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}