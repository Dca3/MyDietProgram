using MyDietProgram.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDietProgram.UI
{
    public partial class MainForm : Form
    {
        Context db;
        public MainForm(Context context)
        {
            db = context;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
