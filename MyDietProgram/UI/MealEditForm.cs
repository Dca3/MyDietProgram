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
        public MealEditForm(Context context, Meal meal)
        {
            db = context;
            InitializeComponent();

            foreach (var item in meal.Foods)
            {
                flpFoods.Controls.Add(CreateFoodComponent(item));
            }
        }

        private Panel CreateFoodComponent(Food food)
        {
            Panel pnlContainer = new Panel();
            MaterialLabel lblFoodName = new MaterialLabel() { Text = food.Name.ToString() };
            MaterialTextBox txtAmount = new MaterialTextBox() { Text = food.Amount.ToString() };
            MaterialButton btnDelete = new MaterialButton() { Text = "-" };

            pnlContainer.Size = new Size(469, 83);
            pnlContainer.Location = new Point(20, 29);

            lblFoodName.Location = new Point(20, 29);

            txtAmount.Size = new Size(100, 50);
            txtAmount.Location = new Point(189, 13);
            txtAmount.UseAccent = false;

            btnDelete.Location = new Point(391, 19);
            btnDelete.UseAccentColor = true;

            pnlContainer.Controls.Add(lblFoodName);
            pnlContainer.Controls.Add(txtAmount);
            pnlContainer.Controls.Add(btnDelete);

            return pnlContainer;
        }
    }
}
