using Microsoft.EntityFrameworkCore;
using MyDietProgram.Classes;

namespace MyDietProgram
{
    public partial class Form1 : Form
    {
        Context db;
        

        public Form1(Classes.Context context)
        {
           //this.db=context;
           // db.Users.Add(new User() { FirstName = "do�an a", LastName = "Ar�c�", Email = "dgncns33@gmail.com",Activity=DailyActivity.Less_Active,Goal=Goal.Gaining_Weigth,Weight=92,Height=192,Gender=Gender.Man,Password="123456",IsAdmin=true });
           // db.SaveChanges();

           // var a = db.Users.FirstOrDefault();
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}