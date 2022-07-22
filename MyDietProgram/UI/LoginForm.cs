using Microsoft.EntityFrameworkCore;
using MyDietProgram.Classes;

namespace MyDietProgram
{
    public partial class LoginForm : Form
    {
        Context db;
        private bool mouseDown;
        private Point lastLocation;

        public LoginForm(Context context)
        {
            //this.db=context;
            // db.Users.Add(new User() { FirstName = "doðan can", LastName = "Arýcý", Email = "dgncn33@gmail.com",Activity=DailyActivity.Less_Active,Goal=Goal.Gaining_Weigth,Weight=92,Height=192,Gender=Gender.Man });
            // db.SaveChanges();

            // var a = db.Users.FirstOrDefault();

            this.db = context;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(db);
            registerForm.ShowDialog();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            CommonMethods.StartMoving(sender, e);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            CommonMethods.Move(this, e);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            CommonMethods.FinishMoving(sender, e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                UserManager userManager = new UserManager(db);
                User user = userManager.GetUser(email, password);
                if (user != null)
                    MessageBox.Show(user.FirstName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}