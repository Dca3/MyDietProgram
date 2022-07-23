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
    public partial class NewFoodForm : MaterialForm
    {
        Context db;
        public NewFoodForm(Context context)
        {
            db = context;
            InitializeComponent();
            var categories = db.Categories.Select(c => c).ToList();
            foreach (var item in categories)
            {
                cbCategories.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Food newFood = new Food()
            {
                Name = txtFoodName.Text,
                AmountDescription = txtAmountDesc.Text,
                Category = (Category)cbCategories.SelectedItem,
                Calorie = Convert.ToInt32(txtCalorie.Text)
            };

            db.Foods.Add(newFood);
            db.SaveChanges();
        }

        private void txtCalorie_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.AcceptOnlyNumbers(txtCalorie.Text, e);
        }
    }
}
