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
            //var meals = db.Meals.Include(m => m.Foods).Where(m => m.UserId == user.UserId && !m.IsDeleted && m.Date.Date == date.Date);
            //var view = meals.Select(m => new
            //{
            //    Öğün = m.Name,
            //    Yiyecekler = m.GetFoods(),
            //    ToplamKalori = m.GetTotalCalorie()
            //}).ToList();

            //dgvDaily.DataSource = view;

            //string totalCal = view.Sum(m => m.ToplamKalori).ToString();
            //lblTotalCal.Text = $"Toplam kalori: {totalCal} kcal";
        }
    }
}
