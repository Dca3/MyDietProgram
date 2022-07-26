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

        public static void StartMoving(MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        public static void Move(Form form, MouseEventArgs e)
        {
            if (mouseDown)
            {
                form.Location = new Point(
                    (form.Location.X - lastLocation.X) + e.X, (form.Location.Y - lastLocation.Y) + e.Y);

                form.Update();
            }
        }

        public static void FinishMoving()
        {
            mouseDown = false;
        }

        public static void AcceptOnlyLetterOrWhiteSpace(KeyPressEventArgs e, string stringvalue)
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
