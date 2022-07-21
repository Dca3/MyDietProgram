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

        public static void StartMoving(object sender, MouseEventArgs e)
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

        public static void FinishMoving(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
