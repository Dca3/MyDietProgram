﻿using MaterialSkin.Controls;
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
                .Where(i => i.UserId == user.UserId && !i.Meal.IsDeleted && i.MealDate.Date == date.Date).ToList();

            var groupedInfos = infos.GroupBy(i => new
            {
                Öğün = i.Meal.Name,
                Yiyecekler = infos.Where(x => x.MealId == i.MealId).Select(x => x.Food).ToList(),
            })
                .Select(i => new
                {
                    Öğün = i.Key.Öğün,
                    Yiyecekler = string.Join(", ", i.Key.Yiyecekler),
                    Kalori = i.Sum(x => x.Food.Calorie)
                }).ToList();

            dgvDaily.DataSource = groupedInfos;

            lblTotalCal.Text = infos.Sum(i => i.Food.Calorie).ToString() + " kcal";
        }
    }
}
