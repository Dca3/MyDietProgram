using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyDietProgram.Classes
{
    public class UserManager
    {

        public Context db { get; set; }


        public UserManager(Context db)
        {
            this.db = db;
        }

        public string sha256_hash(string pwd) { using (SHA256 hash = SHA256Managed.Create()) { return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(pwd)).Select(l => l.ToString("X2"))); } }
        public void CreateUser(string firstName, string lastName, string userMail, string pwd,int activity,int goal,int gender,double weight,double height,int age)
        {
            User user = new User();

            user.FirstName = firstName;
            user.LastName = lastName;
            user.Email = userMail;
            user.Password = sha256_hash(pwd);
            user.Activity =(DailyActivity) activity;
            user.Goal = (Goal)goal;
            user.Gender = (Gender)gender;
            user.Weight=weight;
            user.Height = height;   
            user.Age = age;
            user.CalculatedCalorie = CalculatedCalorie(weight, height, age, activity, gender, goal);

            db.Users.Add(user);
            db.SaveChanges();
        }

        public void CheckedPassword(string password)
        {
            var isUpperCaseConfirmed = false;
            var upperCaseCount = 0;
            var lowerCaseCount = 0;
            var specialSymbolCount = 0;

            foreach (var pw in password.ToCharArray())
            {
                if (Char.IsUpper(pw))
                {
                    upperCaseCount++;
                }

                if (Char.IsLower(pw))
                {
                    lowerCaseCount++;
                }

                if (Char.IsSymbol(pw))
                {
                    specialSymbolCount++;
                }
            }
            if (lowerCaseCount < 3)
            {
                MessageBox.Show("En az 3 küçük harf");
            }

            if (upperCaseCount < 2)
            {
                MessageBox.Show("En az 2 büyük harf");
            }

            if (password.Trim().Length < 8)
            {
                MessageBox.Show("Girdiğiniz şifre 8 karakterin altında olamaz");
            }

            if (specialSymbolCount < 2)
            {
                MessageBox.Show("Girdiğiniz şifre en 2 özel karakter içermelidir");
            }
        }


        public void CheckedEmail(string email)
        {
            string theEmailPattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                   + "@"
                                   + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";

            var isValid = Regex.IsMatch(email, theEmailPattern);

            if (!isValid)
            {
                throw new Exception("Girdiğiniz email geçersizdir");
            }


        }

        public User GetUser(string email, string password)
        {

            if (email==null)
            {
                throw new Exception("Email boş bırakılamaz");
            }
            else if (password == null)
            {

                throw new Exception("Şifre boş bırakılamaz");
            }

            var user = db.Users.Where(u => u.Email == email).FirstOrDefault();

            if (user == null)
            {

                throw new Exception("Kullanıcı bulunamadı");
            }



            if (user.Password != sha256_hash(password))
            {
                throw new Exception("Hatalı şifre girdiniz");
            }

            return user;

        }

        public double CalculatedCalorie(double weight, double height, int age,int activity,int gender,int goal)
        {
            double basalmetabolism = CountBasalMetabolism(weight,height,age,gender);
            double essentialCalorie;
            if (activity==0)
            {
               essentialCalorie=0.25 * basalmetabolism;
            }
            else if (activity==1)
            {
                 essentialCalorie =  0.50 * basalmetabolism;
            }
            else if (activity == 2)
            {
                 essentialCalorie = 0.75 * basalmetabolism;
            }
            else  
            {
                 essentialCalorie = 1 * basalmetabolism;
            }

            if (goal==0)
            {
                return essentialCalorie + 500;
            }
            else if (goal == 1)
            {
                return essentialCalorie - 500;
            }
            else
            {
                return essentialCalorie;
            }
            return 0;
        }


        private double CountBasalMetabolism(double weight,double height,int age,int gender)
        {
            if (gender == 0)
            {
            
              double  basalMetabolismWoman = (10 * weight) + (6.25 * height) - (5 * age) - (161);

                return basalMetabolismWoman;
            }
            else if(gender == 1)
            {
           
               double basalMetabolismMan = (10 * weight) + (8.25 * height) - (5 * age) - (161);

                return basalMetabolismMan;

            }

            return 0;
            
        }


        public void CreateFood(string foodname,int calorie,Category category,int? amount,double? gram)
        {
            Food food = new Food();
            food.Name = foodname;
            food.Category = category;
            food.Calorie = calorie;
            food.Amount = amount;
            food.Gram = gram;
            db.Foods.Add(food);
            db.SaveChanges();
         

           
        }

        public void CreateCategory(string category)
        {

           Category categoryis=new Category();
            categoryis.Name=category;
            db.Categories.Add(categoryis);
            db.SaveChanges();
           

        }


        public void CreateMeal(int mealname,DateTime time)
        {
            Meal meal = new Meal();

            meal.Name = (MealName)mealname;
            meal.Date = time;
         
        }

    }
}
