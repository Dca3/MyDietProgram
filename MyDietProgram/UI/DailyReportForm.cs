using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using MyDietProgram.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDietProgram.UI
{
    public partial class DailyReportForm : MaterialForm
    {
        Context db;
        public DailyReportForm(Context context, User user, DateTime date)
        {
            db = context;
            this.Text = user.FirstName + " " + user.LastName;
            InitializeComponent();
            GetUserData(user, date);
            lblDate.Text = date.ToShortDateString();
        }

        private void GetUserData(User user, DateTime date)
        {
            var infos = db.Infos
                .Include(m => m.Food)
                .Include(m => m.Meal)
                .Where(i => i.UserId == user.UserId && !i.Meal.IsDeleted && i.MealDate.Date == date.Date);

            List<Meal> meals = infos.Select(i => i.Meal).ToList();


            var groupedInfos = infos.GroupBy(i => new
            {
                Öğün = i.MealId
            })
                .Select(i => i.Key.Öğün).ToList();

            var a = "";

            dgvDaily.DataSource = groupedInfos;
        }

        //public string GetFoods(Info info)
        //{
        //    return string.Join(", ", foods);
        //}

        //public double GetTotalCalorie(Info info)
        //{
        //    return foods.Sum(f => f.Calorie);
        //}
    }
}
