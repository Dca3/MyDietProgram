using MaterialSkin.Controls;
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
    public partial class MealEditForm : MaterialForm
    {
        Context db;
        Meal meal;
        public MealEditForm(Context context, Meal meal)
        {
            db = context;
            this.meal = meal;
            InitializeComponent();
            List<int> foodIds = db.Infos.Where(i => i.MealId == meal.MealId && !meal.IsDeleted).Select(i => i.FoodId).ToList();
            //List<Food> foods = db.Foods
            //foreach (var item in meal.Foods)
            //{
            //    flpFoods.Controls.Add(CreateFoodComponent(item));
            //}
        }

        private Panel CreateFoodComponent(Food food)
        {
            Panel pnlContainer = new Panel();
            MaterialLabel lblFoodName = new MaterialLabel() { Text = food.Name.ToString() };
            MaterialTextBox txtAmount = new MaterialTextBox() { Text = food.Amount.ToString() };
            MaterialButton btnDelete = new MaterialButton() { Text = "SİL" };

            pnlContainer.Size = new Size(469, 83);
            pnlContainer.Location = new Point(20, 29);
            pnlContainer.Tag = food;

            lblFoodName.Location = new Point(20, 29);

            txtAmount.Size = new Size(100, 50);
            txtAmount.Location = new Point(189, 13);
            txtAmount.UseAccent = false;

            btnDelete.Location = new Point(391, 19);
            btnDelete.UseAccentColor = true;
            btnDelete.Click += BtnDelete_Click;

            pnlContainer.Controls.Add(lblFoodName);
            pnlContainer.Controls.Add(txtAmount);
            pnlContainer.Controls.Add(btnDelete);

            return pnlContainer;
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            MaterialButton btn = (MaterialButton)sender;
            Food food = (Food)btn.Parent.Tag;



            //meal.Foods.Remove(food);
            db.SaveChanges();

            btn.Parent.Visible = false;
        }
    }
}
