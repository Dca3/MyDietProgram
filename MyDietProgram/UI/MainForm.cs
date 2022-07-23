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

namespace MyDietProgram.UI
{
    public partial class MainForm : MaterialForm
    {
        Context db;
        User user;
        List<Food> foodList;
        public MainForm(Context context, User user)
        {
            db = context;
            this.user = user;
            InitializeComponent();
            FillElements();
            dgvMeals.DataSource = user.Meals;
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
            lblUserCalculatedCalorie.Text = user.CalculatedCalorie.ToString() + " kcal";

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
                lblTotalCalorie.Text = (selectedFood.Calorie * amount).ToString() + " kcal";
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.AcceptOnlyNumbers(txtAmount.Text, e);
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void CreateMealComponent(Meal meal)
        {
            Panel pnlContainer = new Panel();
            MaterialLabel lblMealName = new MaterialLabel() { Text = meal.Name.ToString() };
            MaterialLabel lblFoods = new MaterialLabel() { Text = meal.GetFoods() };
            MaterialLabel lblMealCal = new MaterialLabel() { Text = meal.GetTotalCalorie().ToString() + " kcal" };
            MaterialButton btnEdit = new MaterialButton() { Text = "DÜZENLE" };
            MaterialButton btnDelete = new MaterialButton() { Text = "SİL" };

            pnlContainer.Size = new Size(536, 95);
            pnlContainer.Tag = meal.MealId;

            lblMealName.Location = new Point(14, 11);
            lblMealName.FontType = MaterialSkinManager.fontType.H6;

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
            int mealId = (int)btn.Parent.Tag;
            Meal meal = db.Meals.Where(m => m.MealId == mealId).FirstOrDefault();
            MealEditForm mealEditForm = new MealEditForm(db, meal);
            mealEditForm.ShowDialog();
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

            Meal meal = user.Meals.Where(m => m.MealId == mealId).FirstOrDefault();
            if (meal != null)
                meal.IsDeleted = true;
        }

        private void DeleteMealFromDB(int mealId)
        {
            Meal meal = user.Meals.Where(m => m.MealId == mealId).FirstOrDefault();
            if (meal != null)
                meal.IsDeleted = true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            MealName mealName = (MealName)cbMeals.SelectedIndex;
            Food food = (Food)cbFoods.SelectedItem;
            food.Amount = Convert.ToDouble(txtAmount.Text);
            Meal meal = user.Meals.FirstOrDefault(m => m.Name == mealName && m.Date.Date == dtpDate.Value.Date);

            if (meal == null)
            {
                meal = new Meal()
                {
                    Name = mealName,
                    Date = dtpDate.Value.Date,
                };
                meal.Foods.Add(food);
                user.Meals.Add(meal);
                db.SaveChanges();
                meal = user.Meals.LastOrDefault();
                CreateMealComponent(meal);
            }
            else
            {
                Food foodInMeal = meal.Foods.FirstOrDefault(f => f.Name == food.Name);
                if (foodInMeal == null)
                {
                    meal.Foods.Add(food);
                }
                else
                {

                    ///Düzgün çalışmıyor
                    ///




                    foodInMeal.Amount += food.Amount;
                }
                DeleteMealComponent(meal.MealId);
                CreateMealComponent(meal);
            }
            db.SaveChanges();
        }

        private void UpdateMealComponent(int mealId)
        {

        }

        private void ListMealsOfUser()
        {
            List<Meal> meals = db.Meals.Where(m => m.UserId == 1).ToList();
            
            flpMeals.Controls.Clear();
            
            foreach (Meal meal in meals)
                if (meal.Date.Date == dtpDate.Value.Date)
                    CreateMealComponent(meal);
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ListMealsOfUser();
        }

        private void btnNewFood_Click(object sender, EventArgs e)
        {
            NewFoodForm form = new NewFoodForm(db);
            form.ShowDialog();
        }
    }
}
