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
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

namespace MyDietProgram.UI
{
    public partial class MainForm : MaterialForm
    {
        Context db;
        User user;
        List<Food> foodList;
        readonly MaterialSkinManager manager;
        public MainForm(Context context, User user)
        {

            db = context;
            this.user = user;

            InitializeComponent();
            manager = MaterialSkinManager.Instance;
            manager.EnforceBackcolorOnAllComponents = false;
            manager.AddFormToManage(this);

            FillElements();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            CommonMethods.StartMoving(e);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            CommonMethods.Move(this, e);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            CommonMethods.FinishMoving();
        }

        private void FillElements()
        {
            var categories = db.Categories.Select(c => c).ToList();
            foodList = db.Foods.Select(f => f).ToList();

            foreach (var item in categories)
            {
                cbCategories.Items.Add(item);
            }

            foreach (var item in foodList)
            {
                cbFoods.Items.Add(item);
            }

            cbCategories.SelectedIndex = 0;
            cbFoods.SelectedIndex = 0;

            this.Text = $"Hoşgeldiniz, {user.FirstName} {user.LastName}";
            lblUserCalculatedCalorie.Text = "Günlük hedef: " + user.CalculatedCalorie.ToString() + " kcal";

            ListMealsOfUser();
        }

        private void cbFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cbCategories.SelectedItem.ToString();
            cbFoods.Items.Clear();

            var filteredFoods = db.Foods.Where(f => f.Category.Name == selectedCategory).ToList();

            foreach (var item in filteredFoods)
            {
                cbFoods.Items.Add(item);
            }
            if (filteredFoods.Any())
                cbFoods.SelectedIndex = 0;
        }

        private void UpdateTotal()
        {
            Food selectedFood = cbFoods.SelectedItem as Food;


            decimal amount = txtAmount.Text != "" ? Convert.ToDecimal(txtAmount.Text) : 0;
            if (selectedFood != null)
            {
                decimal totalCal = selectedFood.Calorie * amount;
                lblFoodDetails.Text = string.Format("{0}, {1} kcal", selectedFood.AmountDescription, totalCal.ToString());
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.AcceptOnlyNumbers(txtAmount.Text, e);
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void CreateMealComponent(Info info)
        {
            Meal meal = info.Meal;
            List<Food> foods = db.Infos.Where(i => i.MealId == info.MealId).Select(i => i.Food).ToList();

            Panel pnlContainer = new Panel();
            MaterialLabel lblMealName = new MaterialLabel() { Text = meal.Name.ToString() };
            MaterialLabel lblFoods = new MaterialLabel() { Text = GetFoods(info) };
            MaterialLabel lblMealCal = new MaterialLabel() { Text = GetTotalCalorie(info).ToString() + " kcal" };
            MaterialButton btnEdit = new MaterialButton() { Text = "DÜZENLE" };
            MaterialButton btnDelete = new MaterialButton() { Text = "SİL" };

            pnlContainer.Size = new Size(536, 95);
            pnlContainer.Tag = meal.MealId;

            lblMealName.Location = new Point(14, 11);
            lblMealName.FontType = MaterialSkinManager.fontType.H6;
            lblMealName.Size = new Size(536, 25);

            lblFoods.Location = new Point(14, 46);
            lblFoods.AutoSize = false;
            lblFoods.Size = new Size(245, 19);

            lblMealCal.Location = new Point(290, 48);
            lblMealCal.Size = new Size(75, 19);

            btnEdit.Location = new Point(375, 36);
            btnEdit.Type = MaterialButton.MaterialButtonType.Outlined;
            btnEdit.UseAccentColor = false;
            btnEdit.Click += BtnEdit_Click;

            btnDelete.Location = new Point(468, 36);
            btnDelete.Type = MaterialButton.MaterialButtonType.Outlined;
            btnDelete.UseAccentColor = true;
            btnDelete.Click += BtnDelete_Click;

            pnlContainer.Controls.Add(lblMealName);
            pnlContainer.Controls.Add(lblFoods);
            pnlContainer.Controls.Add(lblMealCal);
            pnlContainer.Controls.Add(btnEdit);
            pnlContainer.Controls.Add(btnDelete);

            flpMeals.Controls.Add(pnlContainer);
        }

        private void BtnEdit_Click(object? sender, EventArgs e)
        {
            var btn = (MaterialButton)sender;
            var _User = db.Infos.Where(x => x.UserId == user.UserId).FirstOrDefault();
            int mealId = (int)btn.Parent.Tag;
            Meal meal = db.Meals.Where(m => m.MealId == mealId).FirstOrDefault();


            MealEditForm mealEditForm = new MealEditForm(db, meal, user);
            manager.AddFormToManage(mealEditForm);
            DialogResult dr = mealEditForm.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                ListMealsOfUser();
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            var btn = (MaterialButton)sender;
            int mealId = (int)btn.Parent.Tag;
            DeleteMealComponent(mealId);
            DeleteMealFromDB(mealId);
        }

        private void DeleteMealComponent(int mealId)
        {
            foreach (Panel item in flpMeals.Controls)
            {
                int tag = (int)item.Tag;
                if (tag == mealId)
                    item.Visible = false;
            }

            Meal meal = db.Meals.Where(m => m.MealId == mealId).FirstOrDefault();
            if (meal != null)
                meal.IsDeleted = true;
        }

        private void DeleteMealFromDB(int mealId)
        {
            Meal meal = db.Meals.Where(m => m.MealId == mealId).FirstOrDefault();
            if (meal != null)
                meal.IsDeleted = true;
            db.SaveChanges();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            MealName mealName = (MealName)cbMeals.SelectedIndex;
            Food food = (Food)cbFoods.SelectedItem;
            List<Info> userInfos = db.Infos.Include(i => i.Meal).Where(i => i.User == user && i.MealDate == dtpDate.Value.Date).ToList();

            List<Meal> userMeals = userInfos.Where(i => !i.Meal.IsDeleted).Select(i => i.Meal).ToList();
            Meal meal = userMeals.Where(m => m.Name == mealName).FirstOrDefault();

            if (meal == null)
            {
                meal = new Meal
                {
                    Name = mealName,
                };
                db.Meals.Add(meal);
                db.SaveChanges();
                Info info = new Info()
                {
                    MealId = meal.MealId,
                    UserId = user.UserId,
                    FoodId = food.FoodId,
                    Amount = Convert.ToDouble(txtAmount.Text),
                    MealDate = dtpDate.Value.Date,
                };
                db.Infos.Add(info);
                db.SaveChanges();
            }
            else
            {
                List<Info> infos = db.Infos.Where(i => i.MealId == meal.MealId).ToList();
                Food foodInMeal = infos.Where(i => i.Food == food).Select(i => i.Food).FirstOrDefault();
                if (foodInMeal == null)
                {
                    Info info = new Info()
                    {
                        MealId = meal.MealId,
                        UserId = user.UserId,
                        FoodId = food.FoodId,
                        Amount = Convert.ToDouble(txtAmount.Text),
                        MealDate = dtpDate.Value.Date,
                    };
                    db.Infos.Add(info);
                    db.SaveChanges();
                }
                else
                {
                    Info info = infos.FirstOrDefault(i => i.Food == foodInMeal);
                    info.Amount += Convert.ToDouble(txtAmount.Text);
                }
                db.SaveChanges();
            }
            db.SaveChanges();
            ListMealsOfUser();
        }

        private void ListMealsOfUser()
        {
            List<Info> userInfos = db.Infos.Include(m => m.Meal).Where(i => i.UserId == user.UserId && !i.Meal.IsDeleted && i.MealDate == dtpDate.Value.Date).ToList();

            double userCalculatedCal = user.CalculatedCalorie;
            flpMeals.Controls.Clear();

            foreach (Info info in userInfos)
            {
                bool isComponentExist = false;
                foreach (Control panel in flpMeals.Controls)
                {
                    if ((int)panel.Tag == info.MealId)
                    {
                        isComponentExist = true;
                    }
                }
                if (!isComponentExist && info.MealDate.Date == dtpDate.Value.Date)
                {
                    List<Food> foods = db.Infos.Where(i => i.MealId == info.MealId && !i.Meal.IsDeleted).Select(i => i.Food).ToList();
                    CreateMealComponent(info);
                    userCalculatedCal -= GetTotalCalorie(info);
                }
            }

            lblUserCalculatedCalorie.Text = "Günlük hedef: " + userCalculatedCal.ToString() + " kcal";
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ListMealsOfUser();
        }

        private void btnNewFood_Click(object sender, EventArgs e)
        {
            NewFoodForm form = new NewFoodForm(db);
            manager.AddFormToManage(form);

            form.ShowDialog();
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            DailyReportForm daily = new DailyReportForm(db, user, dtpDate.Value.Date);
            manager.AddFormToManage(daily);

            daily.ShowDialog();

        }

        private void btnFoodStats_Click(object sender, EventArgs e)
        {
            FoodStatisticsForm form = new FoodStatisticsForm(db);
            manager.AddFormToManage(form);
            form.ShowDialog();
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            OverviewForm daily = new OverviewForm(db, user);
            manager.AddFormToManage(daily);
            daily.ShowDialog();
        }

        public string GetFoods(Info info)
        {
            List<Food> foods = db.Infos.Where(i => i.MealId == info.MealId).Select(i => i.Food).ToList();
            return string.Join(", ", foods);
        }

        public double GetTotalCalorie(Info info)
        {
            List<Info> infos = db.Infos.Where(i => i.MealId == info.MealId).ToList();
            return infos.Sum(i => i.Food.Calorie * i.Amount);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void swhTheme_CheckedChanged(object sender, EventArgs e)
        {
            MaterialSwitch sw = (MaterialSwitch)sender;
            if (sw.Checked)
                manager.Theme = MaterialSkinManager.Themes.DARK;
            else
                manager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
    }
}
