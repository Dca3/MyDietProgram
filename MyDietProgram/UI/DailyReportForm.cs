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
            //var infos = db.Infos
            //    .Include(m => m.Food)
            //    .Include(m => m.Meal)
            //    .Where(i => i.UserId == user.UserId && !i.Meal.IsDeleted && i.MealDate.Date == date.Date)
            //    .ToList();

            //List<Food> foods = db.Infos.Where(i => i.MealId == info.MealId).Select(i => i.Food).ToList();

            //var view = infos.GroupBy(i => new
            //{
            //    Öğün = i.Meal.Name,
            //    Yiyecekler = db.Infos.Where(x => x.MealId == i.MealId).Select(x => x.Food)
            //}).Select(i => new
            //{
            //    Öğün = i.Key.Öğün,
            //    Yiyecekler = i.Key.Yiyecekler.ToString()
            //    ToplamKalori = i.Key.Yiyecekler.Sum(x => x.Calorie)
            //});

            //dgvDaily.DataSource = view.ToList();

            //string totalCal = view.Sum(m => m.ToplamKalori).ToString();
            //lblTotalCal.Text = $"Toplam kalori: {totalCal} kcal";

            //var testTable = infos.GroupBy(i => i.UserId).Select(i => i.Key).ToList();
            //dgvDaily.DataSource = infos;
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
