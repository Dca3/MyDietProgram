using Microsoft.EntityFrameworkCore;
using MyDietProgram.Classes;
using MyDietProgram.UI;

namespace MyDietProgram
{
    public partial class LoginForm : Form
    {
        Context db;
        private bool mouseDown;
        private Point lastLocation;

        public LoginForm(Context context)
        {
            this.db = context;
            InitializeComponent();
            LoadData();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            try
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                UserManager userManager = new UserManager(db);
                User user = userManager.GetUser(email, password);
                if (user != null)
                {
                    MainForm mainForm = new MainForm(db, user);
                    this.Hide();
                    mainForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData()
        {
            var categories = db.Categories.Select(c => c).ToList();

            if (!db.Foods.Any())
            {
                db.Foods.AddRange(
                    new Food() { 
                        Name = "Ali nazik", 
                        Category = categories.Where(c => c.Name == "Et").FirstOrDefault(), 
                        Calorie = 536,
                        AmountDescription = "1 porsiyon"
                    },
                    new Food() { 
                        Name = "Ýskender",
                        Category = categories.Where(c => c.Name == "Et").FirstOrDefault(),
                        Calorie = 755,
                        AmountDescription = "1 porsiyon"
                    },

                    new Food() { Name = "Hamburger",
                        Category = categories.Where(c => c.Name == "Et").FirstOrDefault(),
                        Calorie = 249,
                        AmountDescription = "1 adet"
                    },

                    new Food() { Name = "Çoban salata",
                        Category = categories.Where(c => c.Name == "Salata").FirstOrDefault(),
                        Calorie = 120,
                        AmountDescription = "1 porsiyon"
                    },

                    new Food() { Name = "Balýk",
                        Category = categories.Where(c => c.Name == "Et").FirstOrDefault(),
                        Calorie = 164,
                        AmountDescription = "1 porsiyon"
                    },

                    new Food() { Name = "Kuru fasülye",
                        Category = categories.Where(c => c.Name == "Bakliyat").FirstOrDefault(),
                        Calorie = 146,
                        AmountDescription = "1 porsiyon"
                    },

                    new Food() { Name = "Dondurma",
                        Category = categories.Where(c => c.Name == "Tatlý").FirstOrDefault(),
                        Calorie = 103,
                        AmountDescription = "1 top"
                    },

                    new Food() { Name = "Pilav",
                        Category = categories.Where(c => c.Name == "Bakliyat").FirstOrDefault(),
                        Calorie = 359,
                        AmountDescription = "1 porsiyon"
                    },

                    new Food() { Name = "Domates",
                        Category = categories.Where(c => c.Name == "Sebze").FirstOrDefault(),
                        Calorie = 19,
                        AmountDescription = "1 adet"
                    },

                    new Food() {  Name = "Salatalýk",
                        Category = categories.Where(c => c.Name == "Sebze").FirstOrDefault(),
                        Calorie = 20,
                        AmountDescription = "1 adet"
                    },

                    new Food() {  Name = "Elma",
                        Category = categories.Where(c => c.Name == "Meyve").FirstOrDefault(),
                        Calorie = 46,
                        AmountDescription = "1 adet"
                    },

                    new Food() {  Name = "Armut",
                        Category = categories.Where(c => c.Name == "Meyve").FirstOrDefault(),
                        Calorie = 57,
                        AmountDescription = "1 adet"
                    },

                    new Food() {  Name = "Muz",
                        Category = categories.Where(c => c.Name == "Meyve").FirstOrDefault(),
                        Calorie = 151,
                        AmountDescription = "1 adet"
                    },

                    new Food() {  Name = "Yulaf",
                        Category = categories.Where(c => c.Name == "Bakliyat").FirstOrDefault(),
                        Calorie = 351,
                        AmountDescription = "1 porsiyon"
                    }
                );

                db.SaveChanges();
            }
        }

        private void LoginForm_Shown(object sender,EventArgs e)
        {
            LoadData();
        }
    }
}