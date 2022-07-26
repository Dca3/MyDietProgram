using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using MyDietProgram.Classes;
using MyDietProgram.UI;

namespace MyDietProgram
{
    public partial class LoginForm : MaterialForm
    {
        Context db;
        Random rnd = new Random();


        public LoginForm(Context context)
        {
            this.db = context;
            InitializeComponent();

            if (db.Users.Count() == 0)
                CreateSeedData();
            ShowTutorial();
        }

        private void ShowTutorial()
        {
            TutorialForm tutorial = new TutorialForm();
            tutorial.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm(db);
            DialogResult dr = registerForm.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                this.Show();
            }
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
                    DialogResult dr = mainForm.ShowDialog();
                    if (dr == DialogResult.OK)
                        this.Show();
                    else if (dr == DialogResult.Cancel)
                        Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateSeedData()
        {
            string[] firstNames = { "Patty", "Paddy", "Olive", "Aida", "Maureen", "Teri", "Peg", "Allie", "Liz", "Constanc", "Lois", "Minnie", "Lynn", "Ray", "Lee", "Ray", "Isabelle", "Eileen", "Rita", "Paige" }; //20

            string[] lastNames = { "Yew", "Bugg", "Biologist", "Dactyl", "Legge", "Grater", "Erd", "Mused", "Noring", "Di", "Van", "Ann", "Sin", "Ringing", "Sideways", "Book", "Turner", "Report", "Wind", "Teak" }; //20

            var categories = db.Categories.Select(c => c).ToList();
            UserManager userManager = new UserManager(db);

            //Food Seed
            if (!db.Foods.Any())
            {
                db.Foods.AddRange(
                        new Food()
                     {
                         Name = "�skender",
                         Category = categories.Where(c => c.Name == "Et").FirstOrDefault(),
                         Calorie = 320,
                         AmountDescription = "porsiyon"
                     },
                            new Food()
                            {
                                Name = "Ali nazik",
                                Category = categories.Where(c => c.Name == "Et").FirstOrDefault(),
                                Calorie = 536,
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
                                Name = "�oban salata",
                                Category = categories.Where(c => c.Name == "Salata").FirstOrDefault(),
                                Calorie = 120,
                                AmountDescription = "porsiyon"
                            },
                            new Food()
                            {
                                Name = "Bal�k",
                                Category = categories.Where(c => c.Name == "Et").FirstOrDefault(),
                                Calorie = 164,
                                AmountDescription = "porsiyon"
                            },
                            new Food()
                            {
                                Name = "Kuru fas�lye",
                                Category = categories.Where(c => c.Name == "Bakliyat").FirstOrDefault(),
                                Calorie = 146,
                                AmountDescription = "porsiyon"
                            },
                            new Food()
                            {
                                Name = "Dondurma",
                                Category = categories.Where(c => c.Name == "Tatl�").FirstOrDefault(),
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
                                Name = "Salatal�k",
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
                            },
                            new Food()
                            {
                                Name = "Ekmek",
                                Category = categories.Where(c => c.Name == "Unlu Mam�l").FirstOrDefault(),
                                Calorie = 150,
                                AmountDescription = "dilim"
                            },
                            new Food()
                            {
                                Name = "Makarna",
                                Category = categories.Where(c => c.Name == "Unlu Mam�l").FirstOrDefault(),
                                Calorie = 183,
                                AmountDescription = "porsiyon"
                            },
                            new Food()
                            {
                                Name = "F�st�k",
                                Category = categories.Where(c => c.Name == "Kuruyemi�").FirstOrDefault(),
                                Calorie = 23,
                                AmountDescription = "gram"
                            },
                            new Food()
                            {
                                Name = "Badem",
                                Category = categories.Where(c => c.Name == "Kuruyemi�").FirstOrDefault(),
                                Calorie = 26,
                                AmountDescription = "gram"
                            },
                            new Food()
                            {
                                Name = "Kaju",
                                Category = categories.Where(c => c.Name == "Kuruyemi�").FirstOrDefault(),
                                Calorie = 33,
                                AmountDescription = "gram"
                            },
                            new Food()
                            {
                                Name = "�ay",
                                Category = categories.Where(c => c.Name == "��ecek").FirstOrDefault(),
                                Calorie = 75,
                                AmountDescription = "litre"
                            },
                            new Food()
                            {
                                Name = "Meyve suyu",
                                Category = categories.Where(c => c.Name == "��ecek").FirstOrDefault(),
                                Calorie = 125,
                                AmountDescription = "litre"
                            },
                            new Food()
                            {
                                Name = "Sushi",
                                Category = categories.Where(c => c.Name == "Di�er").FirstOrDefault(),
                                Calorie = 113,
                                AmountDescription = "adet"
                            }
                        );

                db.SaveChanges();

            }


            for (int i = 0; i < firstNames.Length; i++)
            {

                string firstName = firstNames[i];
                string lastName = lastNames[i];
                string age = rnd.Next(15, 80).ToString();
                string email = firstNames[i].ToLowerInvariant() + lastNames[i].ToLowerInvariant() + "@mail.com";
                string pwd = "Test123.";
                int activity = rnd.Next(0, 3);
                int gender = rnd.Next(0, 1);
                int goal = rnd.Next(0, 3);
                string height = rnd.Next(150, 200).ToString();
                string weight = rnd.Next(40, 200).ToString();

                userManager.CreateUser(firstName, lastName, email, pwd, activity, goal, gender, weight, height, age);
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

        DateTime RandomDay()
        {
            DateTime start = new DateTime(2022, 7, 1);
            int range = (DateTime.Today - start.AddDays(5)).Days;
            return start.AddDays(rnd.Next(range));
        }
    }
}