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
    public partial class RegisterForm : Form
    {
        Context db;
        public RegisterForm(Context context)
        {
            db = context;
            InitializeComponent();
            rbFemale.Checked = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager(db);
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            int dailyActivity = cbDailyActivity.SelectedIndex;
            int age = Convert.ToInt32(txtAge.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            double weight = Convert.ToDouble(txtWeight.Text);
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
        }
    }
}
