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
    public partial class MainForm : Form
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

            lblWelcome.Text = $"Hoşgeldiniz, {user.FirstName} {user.LastName}";
            lblUserCalculatedCalorie.Text = user.CalculatedCalorie.ToString() + " kcal";
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
    }
}
