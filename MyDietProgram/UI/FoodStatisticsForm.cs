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
            //var foods = db.Foods.Include(m => m.Meals).Select(f => new
            //{
            //    Ad = f.Name,
            //    Miktar = f.Amount,
            //    Öğünler = f.Meals
            //}).ToList();
            //var groupedFoods = foods.GroupBy(f => new
            //{
            //    Ad = f.Ad,
            //    Miktar = f.Miktar,
            //    Kahvaltı = f.Öğünler.Where(m => m.Name == MealName.Breakfast),
            //    Öğle = f.Öğünler.Where(m => m.Name == MealName.Launch),
            //    Akşam = f.Öğünler.Where(m => m.Name == MealName.Dinner)
            //}).Select(g => new
            //{
            //    Ad = g.Key.Ad,
            //    Miktar = g.Sum(x => x.Miktar),
            //    Kahvaltı = g.Key.Kahvaltı.Count(),
            //    Öğle = g.Key.Öğle.Count(),
            //    Akşam = g.Key.Akşam.Count()
            //}).OrderByDescending(f => f.Miktar);
            //dgvStats.DataSource = groupedFoods.ToList();
            var foods = db.Infos
                .Include(i => i.Food)
                .Include(i => i.Meal)
                .Select(i => new
                {
                    Ad = i.Food.Name,
                    Miktar = i.Amount,
                    Öğün = i.Meal.Name,
                    Öğünler = db.Infos.Where(x => x.Food.Name == i.Food.Name).Select(x => x.Meal).ToList(),
                    Infos = db.Infos.Where(x => x.Food.Name == i.Food.Name).ToList()
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
