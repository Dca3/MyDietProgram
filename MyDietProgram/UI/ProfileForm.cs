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
    public partial class ProfileForm : MaterialForm
    {
        Context db;
        User user;

        public ProfileForm(Context context, User user)
        {
            db = context;
            this.user = user;
            InitializeComponent();
            rbFemale.Checked = true;
            Fill();
        }

        private void Fill()
        {
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtEmail.Text = user.Email;
            txtHeight.Text = user.Height.ToString();
            txtWeight.Text = user.Weight.ToString();
            txtAge.Text = user.Age.ToString();

            rbFemale.Checked = true;
            rbMale.Checked = user.Gender == Gender.Man;
            cbDailyActivity.SelectedIndex = (int)user.Activity;
            cbGoal.SelectedIndex = (int)user.Goal;

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

                userManager.UpdateUser(
                        user,
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
                DialogResult dr = MessageBox.Show("Bilgileriniz güncellenmiştir.");
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

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Password = !chkShowPassword.Checked;
        }
    }
}
