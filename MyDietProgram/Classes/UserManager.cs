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

        private Context db { get; set; }


        public UserManager(Context db)
        {
            this.db = db;
        }

        public string sha256_hash(string pwd) { using (SHA256 hash = SHA256Managed.Create()) { return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(pwd)).Select(l => l.ToString("X2"))); } }
        public void CreateUser(string UserMail, string Pwd)
        {
            User user = new User();

            user.Email = UserMail;
            user.Password = sha256_hash(Pwd);
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

        public void GetUser(string email, string password)
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
           


        }

    }
}
