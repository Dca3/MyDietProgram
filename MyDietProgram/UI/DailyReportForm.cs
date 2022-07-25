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
                .Where(i => i.UserId == user.UserId && !i.Meal.IsDeleted && i.MealDate.Date == date.Date)
                .Select(i => new
                {
                    Öğün = i.Meal.Name,
                    Yiyecek = i.Food.Name,
                    Kalori = i.Food.Calorie
                })
                .ToList();

            var groupedInfos = infos.GroupBy(i => new
            {
                Öğün = i.Öğün,
            })
                .Select(i => new
                {
                    Öğün = i.Key.Öğün,
                    Yiyecekler = string.Join(", ", infos.Select(x => x.Yiyecek).ToList()),
                    Kalori = i.Sum(x => x.Kalori)
                }).ToList();

            dgvDaily.DataSource = groupedInfos;

            lblTotalCal.Text = infos.Sum(i => i.Kalori).ToString() + " kcal";
        }
    }
}
