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

            

            var ınfos=db.Infos.Include(x=>x.Food).Where(x=>x.MealId==meal.MealId).ToList();
            foreach (var item in ınfos)
            {
                flpFoods.Controls.Add(CreateFoodComponent(item));
            }

        }

        private Panel CreateFoodComponent(Info info)
        {
            Food food=info.Food;
            Panel pnlContainer = new Panel();
            MaterialLabel lblFoodName = new MaterialLabel() { Text = food.Name.ToString() };
            MaterialTextBox txtAmount = new MaterialTextBox() { Text = food.Amount.ToString() };
            MaterialButton btnSave = new MaterialButton() { Text = "Kaydet" };

            pnlContainer.Size = new Size(469, 83);
            pnlContainer.Location = new Point(20, 29);
            pnlContainer.Tag = info;

            lblFoodName.Location = new Point(20, 29);

            txtAmount.Size = new Size(100, 50);
            txtAmount.Location = new Point(189, 13);
            txtAmount.UseAccent = false;

            btnSave.Location = new Point(391, 19);
            btnSave.UseAccentColor = true;
            btnSave.Click += btnSave_Click;

            pnlContainer.Controls.Add(lblFoodName);
            pnlContainer.Controls.Add(txtAmount);
            pnlContainer.Controls.Add(btnSave);

            return pnlContainer;
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            MaterialButton btn = (MaterialButton)sender;

            

            Info info = (Info)btn.Parent.Tag;
            MaterialTextBox txtbox=new MaterialTextBox();
            foreach (MaterialTextBox  item in btn.Parent.Controls)
            {
                if (item.GetType() is MaterialTextBox)
                {
                    txtbox = (MaterialTextBox)item;
                }
            }
            var ınfos = db.Infos.Where(x => x.FoodId == info.FoodId).ToList();
            var usersfoodsinfarmation = ınfos.Where(x => x.UserId == _user.UserId).FirstOrDefault();
            usersfoodsinfarmation.Amount =Convert.ToDouble( txtbox.Text);

            flpFoods.Controls.Add(CreateFoodComponent(usersfoodsinfarmation));


            db.SaveChanges();


            btn.Parent.Visible = false;
        }

        private void MealEditForm_Load(object sender, EventArgs e)
        {

        }


    }
}
