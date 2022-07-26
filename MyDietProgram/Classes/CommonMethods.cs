using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDietProgram.Classes
{
    static class CommonMethods
    {
        public static bool mouseDown { get; set; }
        public static Point lastLocation;

        public static void AcceptOnlyLetterOrWhiteSpace(string stringvalue, KeyPressEventArgs e)
        {
            char pressedkey = e.KeyChar;
            if (char.IsLetter(pressedkey) || char.IsWhiteSpace(pressedkey))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public static void AcceptOnlyNumbers(string txt, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && txt.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
