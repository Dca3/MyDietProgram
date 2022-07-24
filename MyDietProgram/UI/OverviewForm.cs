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
    public partial class OverviewForm : MaterialForm
    {
        Context db;
        public OverviewForm(Context context)
        {
            db = context;
            InitializeComponent();
        }

        private void Weekly()
        {

        }
    }
}
