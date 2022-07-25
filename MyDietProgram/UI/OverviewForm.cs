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
    public partial class OverviewForm : MaterialForm
    {
        Context db;
        User user;
        List<TableInfo> tableInfos;
        List<TableInfo> userTableInfos;
        DateTime startDate = DateTime.Today;
        DateTime finishDate = DateTime.Today;
        public OverviewForm(Context context, User user)
        {
            db = context;
            this.user = user;

            InitializeComponent();
            SetWeekDates();
            UpdateTable();
        }

        class TableInfo
        {
            public string Name { get; set; }
            public MealName MealName { get; set; }
            public Food Food { get; set; }
            public double Amount { get; set; }
        }

        private void GetInfosByStartAndFinishDate(DateTime startDate, DateTime finishDate)
        {
            tableInfos = db.Infos
                 .Include(x => x.Meal)
                 .Include(x => x.User)
                 .Where(x => !x.Meal.IsDeleted && x.MealDate > startDate && x.MealDate < finishDate && x.User != user)
                 .Select(x => new TableInfo
                 {
                     Name = x.User.FirstName + " " + x.User.LastName,
                     MealName = x.Meal.Name,
                     Food = x.Food,
                     Amount = x.Amount
                 })
                 .ToList();

            userTableInfos = db.Infos
                .Include(x => x.Meal)
                .Include(x => x.User)
                .Where(x => !x.Meal.IsDeleted && x.MealDate > startDate && x.MealDate < finishDate && x.User == user)
                .Select(x => new TableInfo
                {
                    Name = x.User.FirstName + " " + x.User.LastName,
                    MealName = x.Meal.Name,
                    Food = x.Food,
                    Amount = x.Amount
                })
                .ToList();
        }

        private void FilterByMeal()
        {
            var userInfosGroupedByMeal = userTableInfos.GroupBy(x => new
            {
                Ad = x.Name,
                Öğün = x.MealName
            })
                .Select(x => new
                {
                    Ad = x.Key.Ad,
                    Öğün = x.Key.Öğün,
                    Kalori = x.Sum(y => y.Food.Calorie * y.Amount),
                });

            var groupedByMeal = tableInfos.GroupBy(x => new
            {
                Ad = x.Name,
                Öğün = x.MealName
            })
            .Select(x => new
            {
                Ad = x.Key.Ad,
                Öğün = x.Key.Öğün,
                Kalori = x.Sum(y => y.Food.Calorie * y.Amount),
                SizinKaloriniz = userInfosGroupedByMeal.Where(y => y.Öğün == x.Key.Öğün).Select(y => y.Kalori).FirstOrDefault(),
                Fark = x.Sum(y => y.Food.Calorie * y.Amount) - userInfosGroupedByMeal.Where(y => y.Öğün == x.Key.Öğün).Select(y => y.Kalori).FirstOrDefault()
            }).OrderBy(x => x.Ad);

            dgvResults.DataSource = groupedByMeal.ToList();
        }

        private void FilterByCategory()
        {
            var userInfosGroupedByCategory = userTableInfos.GroupBy(x => new
            {
                Ad = x.Name,
                Kategori = x.Food.Category
            })
                .Select(x => new
                {
                    Ad = x.Key.Ad,
                    Kategori = x.Key.Kategori,
                    Kalori = x.Sum(y => y.Food.Calorie * y.Amount),
                });

            var groupedByCategory = tableInfos.GroupBy(x => new
            {
                Ad = x.Name,
                Kategori = x.Food.Category
            })
            .Select(x => new
            {
                Ad = x.Key.Ad,
                Kategori = x.Key.Kategori,
                Kalori = x.Sum(y => y.Food.Calorie * y.Amount),
                SizinKaloriniz = userInfosGroupedByCategory.Where(y => y.Kategori == x.Key.Kategori).Select(y => y.Kalori).FirstOrDefault(),
                Fark = x.Sum(y => y.Food.Calorie * y.Amount) - userInfosGroupedByCategory.Where(y => y.Kategori == x.Key.Kategori).Select(y => y.Kalori).FirstOrDefault()
            }).OrderBy(x => x.Ad);

            dgvResults.DataSource = groupedByCategory.ToList();
        }

        private void SetWeekDates()
        {
            startDate = DateTime.Now;
            while (startDate.DayOfWeek != DayOfWeek.Monday)
            {
                startDate = startDate.AddDays(-1);
            };

            finishDate = startDate.AddDays(7);
            UpdateDateString();
        }

        private void SetMonthDates()
        {
            startDate = startDate.AddDays(-startDate.Day + 1);
            finishDate = finishDate.AddDays(DateTime.DaysInMonth(finishDate.Year, finishDate.Month) - finishDate.Day);
            UpdateDateString();
        }

        private void UpdateDateString()
        {
            lblDates.Text = startDate.ToShortDateString() + " - " + finishDate.ToShortDateString();
        }

        private void rbMeal_CheckedChanged(object sender, EventArgs e)
        {
            FilterByMeal();
        }

        private void rbCategory_CheckedChanged(object sender, EventArgs e)
        {
            FilterByCategory();
        }

        private void rbWeek_CheckedChanged(object sender, EventArgs e)
        {
            SetWeekDates();
            UpdateTable();
            UpdateDateString();
        }

        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            SetMonthDates();
            UpdateTable();
            UpdateDateString();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (rbWeek.Checked)
            {
                startDate = startDate.AddDays(-7);
                finishDate = finishDate.AddDays(-7);
            }
            else if (rbMonth.Checked)
            {
                startDate = startDate.AddMonths(-1);
                finishDate = finishDate.AddMonths(-1);
            }

            UpdateTable();
            UpdateDateString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbWeek.Checked)
            {
                startDate = startDate.AddDays(7);
                finishDate = finishDate.AddDays(7);
            }
            else if (rbMonth.Checked)
            {
                startDate = startDate.AddMonths(1);
                finishDate = finishDate.AddMonths(1);
            }

            UpdateTable();
            UpdateDateString();
        }

        private void UpdateTable()
        {
            GetInfosByStartAndFinishDate(startDate, finishDate);
            if (rbMeal.Checked)
            {
                FilterByMeal();
            }
            else if (rbCategory.Checked)
            {
                FilterByCategory();
            }
            UpdateDateString();
        }
    }
}
