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
        public void CreateUser(string firstName, string lastName, string userMail, string pwd, int activity, int goal, int gender, double weight, double height, int age)
        {
            User user = new User();

            user.FirstName = firstName;
            user.LastName = lastName;
            user.Email = userMail;
            user.Password = sha256_hash(pwd);
            user.Activity = (DailyActivity)activity;
            user.Goal = (Goal)goal;
            user.Gender = (Gender)gender;
            user.Weight = weight;
            user.Height = height;
            user.Age = age;
            user.CalculatedCalorie = CalculatedCalorie(weight, height, age, activity, gender, goal);

            db.Users.Add(user);
            db.SaveChanges();
        }

        public string CheckedPassword(string password)
        {

            //Regex sampleRegex = new Regex(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{2,})$");//isStrongPassword
            //bool isStrongPassword = sampleRegex.IsMatch(password);
            //Ayrı MEtod Yazıldı Bunun İçin İsvalid
            //Rules ,Test İçin Bu değerleri 1 E çektim Sonrasında Rule Koyabılırız
            int minUpper = 1;
            int minLower = 1;
            int minLength = 8;
            int maxLength = 15;
            int minNumber = 1;
            int minCharacter = 1;
            string allowedSpecials = "@#/.!')-_?;,:+-*";

            char[] characters = password.ToCharArray();

            int upper = 0;
            int lower = 0;
            int character = 0;
            int number = 0;
            int length = password.Length;
            int illegalCharacters = 0;


            
            foreach (char enteredCharacters in characters)
            {
                if (char.IsUpper(enteredCharacters))
                {
                    upper = upper + 1;
                }
                else if (char.IsLower(enteredCharacters))
                {
                    lower = lower + 1;
                }
                else if (char.IsNumber(enteredCharacters))
                {
                    number = number + 1;
                }
                else if (allowedSpecials.Contains(enteredCharacters.ToString()))
                {
                    character = character + 1;
                }
                else
                {
                    illegalCharacters = illegalCharacters + 1;
                }

            }

            if (upper < minUpper || lower < minLower || length < minLength || length > maxLength || illegalCharacters >= 1 || character < minCharacter || number<minNumber)
            {
                throw new Exception("Something's not right, your password does not meet the minimum security criteria");
                
            }
            else
            {
                return password; 
            }
        }


        public string CheckedEmail(string email)
        {
            string theEmailPattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                   + "@"
                                   + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";

            var isValid = Regex.IsMatch(email, theEmailPattern);

            if (!isValid)
            {
                throw new Exception("Girdiğiniz email geçersizdir");

            }
            return email;
        }

        public User GetUser(string email, string password)
        {

            if (email == null)
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

        public double CalculatedCalorie(double weight, double height, int age, int activity, int gender, int goal)
        {
            double basalmetabolism = CountBasalMetabolism(weight, height, age, gender);
            double essentialCalorie;
            if (activity == 0 || goal==0)
            {
                essentialCalorie = 0.25 * basalmetabolism;
                return essentialCalorie + 500;
            }
            else if (activity == 0 || goal==1)
            {
                essentialCalorie = 0.50 * basalmetabolism;
                return essentialCalorie - 200;
            }
            else if (activity == 1 || goal == 0 )
            {
                essentialCalorie = 0.50 * basalmetabolism;
                return essentialCalorie + 500;
            }
            else if (activity == 1 || goal == 1)
            {
                essentialCalorie = 0.50 * basalmetabolism;
                return essentialCalorie - 200;
            }
            else if (activity == 2 || goal == 0)
            {
                essentialCalorie = 0.75 * basalmetabolism;
                return essentialCalorie + 500;
            }
            else if (activity == 2 || goal == 1)
            {
                essentialCalorie = 0.75 * basalmetabolism;
                return essentialCalorie - 200;
            }
            else
            {
               return essentialCalorie = 1 * basalmetabolism;
            }
        }


        private double CountBasalMetabolism(double weight, double height, int age, int gender)
        {
            if (gender == 0)
            {
                double basalMetabolismWoman = (10 * weight) + (6.25 * height) - (5 * age) - (161);
                return basalMetabolismWoman;
            }
            else if (gender == 1)
            {
                double basalMetabolismMan = (10 * weight) + (8.25 * height) - (5 * age) - (161);
                return basalMetabolismMan;
            }
            return 0;
        }


        public void CreateFood(string foodname, int calorie, Category category)
        {
            Food food = new Food();
            food.Name = foodname;
            food.Category = category;
            food.Calorie = calorie;

            db.Foods.Add(food);
            db.SaveChanges();
        }

        public void CreateCategory(string category)
        {

            Category categoryis = new Category();
            categoryis.Name = category;
            db.Categories.Add(categoryis);
            db.SaveChanges();
        }

        public void CheckIsNumber(string value, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == ',') && value.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        public void CheckIsWholeNumber(string value, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        public bool ValidatePassword(string password)
        {
            const int MINLENGTH = 8;


            if (password == null) throw new ArgumentNullException();

            bool meetsLengthRequirements = password.Length >= MINLENGTH;
            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;
            bool hasSymbolDigit = false;
            string specialChar = @"*|!#$%&/()=?»«@£§€{}.-;'<>,";

            if (meetsLengthRequirements)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpperCaseLetter = true;
                    else if (char.IsLower(c)) hasLowerCaseLetter = true;
                    else if (char.IsDigit(c)) hasDecimalDigit = true;
                    else if (specialChar.Contains(c)) hasSymbolDigit = true;
                }
            }

            bool isValid = meetsLengthRequirements
                        && hasUpperCaseLetter
                        && hasLowerCaseLetter
                        && hasDecimalDigit
                        && hasSymbolDigit
                        ;
            return isValid;
        }


    }
}
