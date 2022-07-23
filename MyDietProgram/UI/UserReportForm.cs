using MaterialSkin.Controls;
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
    public partial class UserReportForm : MaterialForm
    {
        Context db;
        public UserReportForm(Context context, User user)
        {
            db = context;
            this.Text = user.FirstName + " " + user.LastName;
            InitializeComponent();
        }
    }
}
