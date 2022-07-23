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
        private readonly LoginForm _lgnfrm;

        public RegisterForm(Context context)
        {
            db = context;
            InitializeComponent();
            rbFemale.Checked = true;
            _lgnfrm = new LoginForm(db);
            Fill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fill()
        {
            txtFirstName.Text = "Test" + new Random().Next(1, 1000);
            txtLastName.Text = "Test" + new Random().Next(1, 1000);
            txtHeight.Text = new Random().Next(100, 200).ToString();
            txtWeight.Text = new Random().Next(50, 140).ToString();
            txtFirstName.Text = "Test" + new Random().Next(1, 1000);
            txtFirstName.Text = "Test" + new Random().Next(1, 1000);
            txtEmail.Text = "Test" + new Random().Next(1, 1000) + "@test.com";
            txtPassword.Text = "Test123.";
            txtAge.Text = new Random().Next(10, 49).ToString();
            var gender = new Random().Next(1, 3);
            if (gender%2==0)
            {
                rbFemale.Checked=false;
                rbMale.Checked = true;
            }
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


            try
            {
                if (btnRegister.Text.ToLower() == "giriş yap")
                {
                    this.Hide();
                    _lgnfrm.ShowDialog();
                }
                else
                {
                    string checkMail = txtEmail.Text;
                    string checkPassword = txtPassword.Text;


                    UserManager userManager = new UserManager(db);
                    var a = userManager.ValidatePassword(checkPassword);//Password Strongmu Ona Bakar 
                    string firstName = txtFirstName.Text;
                    string lastName = txtLastName.Text;
                    string email = userManager.CheckedEmail(checkMail);
                    string password = userManager.CheckedPassword(checkPassword);
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
                    MessageBox.Show("Kayıt İşlemi Başarılı. Giriş Yapmak için Giriş Yapa Tıklayınız.");
                    btnRegister.Text = "Giriş Yap";

                }
            }
            catch (Exception ex)
            {
                db.ChangeTracker.Clear();
                MessageBox.Show(ex.Message);
                //TODO Hata lduğunda db track temizle
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            UserManager userManager = new UserManager(db);
            userManager.CheckIsWholeNumber(txtAge.Text, e);
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            UserManager userManager = new UserManager(db);
            userManager.CheckIsNumber(txtWeight.Text, e);
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            UserManager userManager = new UserManager(db);
            userManager.CheckIsNumber(txtHeight.Text, e);
        }

    }
}
