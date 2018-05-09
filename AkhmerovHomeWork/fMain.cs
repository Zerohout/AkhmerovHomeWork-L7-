using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkhmerovHomeWork
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnDoubler_Click(object sender, EventArgs e)
        {
            Hide();
            var fd = new fDoubler();
            fd.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuessTheNum_Click(object sender, EventArgs e)
        {
            Hide();
            var fgtn = new fGuessTheNumber();
            fgtn.Show();
        }

        private void btnVacation_Click(object sender, EventArgs e)
        {
            Hide();
            var fv = new fVacation();
            fv.Show();
        }
    }
}
