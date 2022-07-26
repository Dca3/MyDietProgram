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
    public partial class MealEditForm : MaterialForm
    {
        Context db;
        Meal meal;
        User _user;

       
        public MealEditForm(Context context, Meal meal,User user)
        {
            db = context;
            this._user=user;
            this.meal = meal;
            InitializeComponent();

            ListFoodsOfMeal();
        }

        private void ListFoodsOfMeal()
        {
            var infos = db.Infos.Include(x => x.Food).Where(x => x.MealId == meal.MealId).ToList();
            foreach (var item in infos)
            {
                flpFoods.Controls.Add(CreateFoodComponent(item));
            }
        }

        private Panel CreateFoodComponent(Info info)
        {
            Food food=info.Food;
            Panel pnlContainer = new Panel();
            MaterialLabel lblFoodName = new MaterialLabel() { Text = food.Name.ToString() };
            MaterialTextBox txtAmount = new MaterialTextBox() { Text = info.Amount.ToString() };
            MaterialButton btnSave = new MaterialButton() { Text = "Kaydet" };
            MaterialButton btnDelete = new MaterialButton() { Text = "Sil" };

            pnlContainer.Size = new Size(516, 83);
            pnlContainer.Location = new Point(20, 29);
            pnlContainer.Tag = info;

            lblFoodName.Location = new Point(20, 29);

            txtAmount.Size = new Size(100, 50);
            txtAmount.Location = new Point(189, 13);
            txtAmount.UseAccent = false;
            txtAmount.Tag = info;

            btnSave.Location = new Point(341, 19);
            btnSave.UseAccentColor = true;
            btnSave.Click += btnSave_Click;

            btnDelete.Location = new Point(440, 19);
            btnDelete.UseAccentColor = true;
            btnDelete.Click += BtnDelete_Click;

            pnlContainer.Controls.Add(lblFoodName);
            pnlContainer.Controls.Add(txtAmount);
            pnlContainer.Controls.Add(btnSave);
            pnlContainer.Controls.Add(btnDelete);

            return pnlContainer;
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Panel panel = ((Control)sender).Parent as Panel;
            Info info = panel.Tag as Info;
            panel.Visible = false;
            db.Infos.Remove(info);
            db.SaveChanges();
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            MaterialButton btn = (MaterialButton)sender;
            Info info = (Info)btn.Parent.Tag;
            MaterialTextBox txtbox=new MaterialTextBox();

            foreach (Control item in btn.Parent.Controls)
            {
                if ((Info)item.Tag == info)
                {
                    txtbox = (MaterialTextBox)item;
                }
            }

            info.Amount = Convert.ToDouble(txtbox.Text);

            flpFoods.Controls.Add(CreateFoodComponent(info));

            db.SaveChanges();

            btn.Parent.Visible = false;
        }
    }
}
