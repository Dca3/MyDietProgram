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

namespace MyDietProgram
{
    public partial class RegisterForm : MaterialForm
    {
        Context db;

        public RegisterForm(Context context)
        {
            db = context;
            InitializeComponent();
            rbFemale.Checked = true;
            //Fill();
        }

        private void Fill()
        {
            txtFirstName.Text = "Test" + new Random().Next(1, 1000);
            txtLastName.Text = "Test" + new Random().Next(1, 1000);
            txtHeight.Text = new Random().Next(100, 200).ToString();
            txtWeight.Text = new Random().Next(50, 140).ToString();
            txtFirstName.Text = "Test" + new Random().Next(1, 1000);
            txtFirstName.Text = "Test" + new Random().Next(1, 1000);
            txtEmail.Text = "Test" + new Random().Next(1, 1000) + "@mail.com";
            txtPassword.Text = "Test123.";
            txtAge.Text = new Random().Next(10, 49).ToString();
            var gender = new Random().Next(1, 3);
            if (gender % 2 == 0)
            {
                rbFemale.Checked = false;
                rbMale.Checked = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                UserManager userManager = new UserManager(db);
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                int dailyActivity = cbDailyActivity.SelectedIndex;
                string age = txtAge.Text;
                string height = txtHeight.Text;
                string weight = txtWeight.Text;
                int gender = rbFemale.Checked ? 0 : 1; //0 Female, 1 Male
                int goal = cbGoal.SelectedIndex;

                userManager.CreateUser(
                        firstName,
                        lastName,
                        email,
                        password,
                        dailyActivity,
                        goal,
                        gender,
                        weight,
                        height,
                        age
                    );
                DialogResult dr = MessageBox.Show("Kaydınız oluşturulmuştur.");
                if (dr == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                db.ChangeTracker.Clear();
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.AcceptOnlyNumbers(txtAge.Text, e);
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.AcceptOnlyNumbers(txtWeight.Text, e);
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.AcceptOnlyNumbers(txtHeight.Text, e);
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.AcceptOnlyLetterOrWhiteSpace(txtFirstName.Text, e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonMethods.AcceptOnlyLetterOrWhiteSpace(txtLastName.Text, e);
        }
    }
}
