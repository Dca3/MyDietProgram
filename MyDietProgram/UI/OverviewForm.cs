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
        public OverviewForm(Context context, User user)
        {
            db = context;
            this.user = user;
            InitializeComponent();
            DateTime start = DateTime.ParseExact("2022-07-20", "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
            DateTime finish = DateTime.ParseExact("2022-07-27", "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
            GetMealsByStartAndFinishDate(start, finish);
        }

        private void GetMealsByStartAndFinishDate(DateTime startDate, DateTime finishDate)
        {
            var infos = db.Infos
                .Include(x => x.Meal)
                .Include(x => x.User)
                .Where(x => !x.Meal.IsDeleted && x.MealDate > startDate && x.MealDate < finishDate && x.User != user)
                .Select(x => new
                {
                    Ad = x.User.FirstName + " " + x.User.LastName,
                    Öğün = x.Meal.Name,
                    Yiyecek = x.Food
                })
                .ToList();

            var userInfos = db.Infos
                .Include(x => x.Meal)
                .Include(x => x.User)
                .Where(x => !x.Meal.IsDeleted && x.MealDate > startDate && x.MealDate < finishDate && x.User == user)
                .Select(x => new
                {
                    Ad = x.User.FirstName + " " + x.User.LastName,
                    Öğün = x.Meal.Name,
                    Yiyecek = x.Food
                })
                .ToList();

            var userInfosGroupedByMeal = infos.GroupBy(x => new
            {
                Ad = x.Ad,
                Öğün = x.Öğün
            })
                .Select(x => new
                {
                    Ad = x.Key.Ad,
                    Öğün = x.Key.Öğün,
                    Kalori = x.Select(y => y.Yiyecek.Calorie).Sum(),
                });

            var groupedByMeal = infos.GroupBy(x => new
            {
                Ad = x.Ad,
                Öğün = x.Öğün
            })
            .Select(x => new
            {
                Ad = x.Key.Ad,
                Öğün = x.Key.Öğün,
                Kalori = x.Select(y => y.Yiyecek.Calorie).Sum(),
                Fark = x.Select(y => y.Yiyecek.Calorie).Sum() - userInfosGroupedByMeal.Where(y => y.Öğün == x.Key.Öğün).Select( y=> y.Kalori).FirstOrDefault()
            });

            dgvResults.DataSource = groupedByMeal.ToList();
        }
    }
}
