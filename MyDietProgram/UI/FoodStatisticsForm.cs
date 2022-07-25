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
            var foods = db.Infos
                .Include(i => i.Food)
                .Include(i => i.Meal)
                .Where(i => !i.Meal.IsDeleted)
                .Select(i => new
                {
                    Ad = i.Food.Name,
                    Miktar = i.Amount,
                    Öğün = i.Meal.Name,
                }).ToList();

            var groupedFoods = foods.GroupBy(f => new
            {
                Ad = f.Ad,
            }).Select(g => new
            {
                Ad = g.Key.Ad,
                Miktar = g.Sum(x => x.Miktar),
                Kahvaltı = g.Where(x=> x.Öğün == MealName.Kahvaltı).Select(x => x.Miktar).Sum(),
                ÖğleYemeği = g.Where(x=> x.Öğün == MealName.ÖğleYemeği).Select(x => x.Miktar).Sum(),
                AkşamYemeği = g.Where(x=> x.Öğün == MealName.AkşamYemeği).Select(x => x.Miktar).Sum(),
                Atıştırma = g.Where(x=> x.Öğün == MealName.Atıştırma).Select(x => x.Miktar).Sum(),

            }).OrderByDescending(f => f.Miktar);

            dgvStats.DataSource = groupedFoods.ToList();
        }
    }
}
