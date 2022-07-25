using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using MyDietProgram.Classes;
using MyDietProgram.UI;

namespace MyDietProgram
{
    public partial class LoginForm : MaterialForm
    {
        Context db;

        public LoginForm(Context context)
        {
            this.db = context;
            InitializeComponent();
            

            LoadData();
            if(db.Users.Count() == 0)
                CreateSeedData();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm(db);
            registerForm.ShowDialog();
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
                    new Food()
                    {
                        Name = "Ali nazik",
                        Category = categories.Where(c => c.Name == "Et").FirstOrDefault(),
                        Calorie = 536,
                        AmountDescription = "porsiyon"
                    },
                    new Food()
                    {
                        Name = "Ýskender",
                        Category = categories.Where(c => c.Name == "Et").FirstOrDefault(),
                        Calorie = 755,
                        AmountDescription = "porsiyon"
                    },

                    new Food()
                    {
                        Name = "Hamburger",
                        Category = categories.Where(c => c.Name == "Et").FirstOrDefault(),
                        Calorie = 249,
                        AmountDescription = "adet"
                    },

                    new Food()
                    {
                        Name = "Çoban salata",
                        Category = categories.Where(c => c.Name == "Salata").FirstOrDefault(),
                        Calorie = 120,
                        AmountDescription = "porsiyon"
                    },

                    new Food()
                    {
                        Name = "Balýk",
                        Category = categories.Where(c => c.Name == "Et").FirstOrDefault(),
                        Calorie = 164,
                        AmountDescription = "porsiyon"
                    },

                    new Food()
                    {
                        Name = "Kuru fasülye",
                        Category = categories.Where(c => c.Name == "Bakliyat").FirstOrDefault(),
                        Calorie = 146,
                        AmountDescription = "porsiyon"
                    },

                    new Food()
                    {
                        Name = "Dondurma",
                        Category = categories.Where(c => c.Name == "Tatlý").FirstOrDefault(),
                        Calorie = 103,
                        AmountDescription = "top"
                    },

                    new Food()
                    {
                        Name = "Pilav",
                        Category = categories.Where(c => c.Name == "Bakliyat").FirstOrDefault(),
                        Calorie = 359,
                        AmountDescription = "porsiyon"
                    },

                    new Food()
                    {
                        Name = "Domates",
                        Category = categories.Where(c => c.Name == "Sebze").FirstOrDefault(),
                        Calorie = 19,
                        AmountDescription = "adet"
                    },

                    new Food()
                    {
                        Name = "Salatalýk",
                        Category = categories.Where(c => c.Name == "Sebze").FirstOrDefault(),
                        Calorie = 20,
                        AmountDescription = "adet"
                    },

                    new Food()
                    {
                        Name = "Elma",
                        Category = categories.Where(c => c.Name == "Meyve").FirstOrDefault(),
                        Calorie = 46,
                        AmountDescription = "adet"
                    },

                    new Food()
                    {
                        Name = "Armut",
                        Category = categories.Where(c => c.Name == "Meyve").FirstOrDefault(),
                        Calorie = 57,
                        AmountDescription = "adet"
                    },

                    new Food()
                    {
                        Name = "Muz",
                        Category = categories.Where(c => c.Name == "Meyve").FirstOrDefault(),
                        Calorie = 151,
                        AmountDescription = "adet"
                    },

                    new Food()
                    {
                        Name = "Yulaf",
                        Category = categories.Where(c => c.Name == "Bakliyat").FirstOrDefault(),
                        Calorie = 351,
                        AmountDescription = "porsiyon"
                    }
                );

                db.SaveChanges();

            }
        }

        private void CreateSeedData()
        {
            Random rnd = new Random();
            string[] firstNames = { "Patty", "Paddy", "Olive", "Aida", "Maureen", "Teri", "Peg", "Allie", "Liz", "Constanc", "Lois", "Minnie", "Lynn", "Ray", "Lee", "Ray", "Isabelle", "Eileen", "Rita", "Paige"}; //20

            string[] lastNames = { "Yew", "Bugg", "Biologist", "Dactyl", "Legge", "Grater", "Erd", "Mused", "Noring", "Di", "Van", "Ann", "Sin", "Ringing", "Sideways", "Book", "Turner", "Report", "Wind", "Teak" }; //20

            for (int i = 0; i < firstNames.Length; i++)
            {
                User user = new User()
                {
                    FirstName = firstNames[i],
                    LastName = lastNames[i],
                    Age = rnd.Next(15, 80),
                    Email = firstNames[i].ToLower() + lastNames[i].ToLower() + "@mail.com",
                    Gender = (Gender)rnd.Next(0, 1),
                    Activity = (DailyActivity)rnd.Next(0, 3),
                    Goal = (Goal)rnd.Next(0, 3),
                    Height = rnd.Next(150, 200),
                    Weight = rnd.Next(40, 200),
                    Password = "Test123.",
                };

                db.Users.Add(user);
                db.SaveChanges();
            }

            for (int i = 0; i < 50; i++)
            {
                Meal meal = new Meal
                {
                    Name = (MealName)rnd.Next(0, 3),
                    IsDeleted = rnd.Next(0, 5) < 4,
                };

                db.Meals.Add(meal);
                db.SaveChanges();
            }

            for (int i = 0; i < 250; i++)
            {
                Info info = new Info()
                {
                    UserId = rnd.Next(1, 20),
                    MealId = rnd.Next(1, 50),
                    FoodId = rnd.Next(1, 14),
                    Amount = rnd.Next(1, 5),
                    MealDate = RandomDay()
                };
                db.Infos.Add(info);
                db.SaveChanges();
            }
        }

        private Random gen = new Random();
        DateTime RandomDay()
        {
            DateTime start = new DateTime(2022, 7, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}