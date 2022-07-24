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
    public partial class FoodStatisticsForm : MaterialForm
    {
        Context db;
        public FoodStatisticsForm(Context context)
        {
            db = context;
            InitializeComponent();
            GetStats();
        }

        private void GetStats()
        {
            var foods = db.Foods.FromSqlRaw("SELECT f.* FROM FoodMeal fm RIGHT JOIN Meals m ON m.MealId = fm.MealsMealId RIGHT JOIN Foods f ON f.FoodId = fm.FoodsFoodId where m.IsDeleted = 0").Select(f => new
            {
                Ad = f.Name,
                Miktar = f.Amount
            }).ToList();

            var groupedFoods = foods.GroupBy(f => new {
                Ad = f.Ad,
                Miktar = f.Miktar
            }).Select( g=> new {
                Ad = g.Key.Ad,
                Miktar = g.Sum( x => x.Miktar)
            });
            dgvStats.DataSource = groupedFoods.ToList();

            
        }
    }
}
