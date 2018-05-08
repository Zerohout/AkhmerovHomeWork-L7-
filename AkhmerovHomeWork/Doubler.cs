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
   
    public partial class fDoubler : Form
    {
        static int userNum = 1;
        static int globalCount = 0;
        static int undoCount = 0;
        static List<int> undoNum = new List<int>();
        public fDoubler()
        {
            InitializeComponent();
        }

        private void fDoubler_Load(object sender, EventArgs e)
        {
            Tumbler(false);
            btnStartAgain.Text = "Начать";
            


        }



        private void lblUndoCount_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(lblUndoCount.Text) > 3)
            {
                lblUndoRemain.ForeColor = Color.Green;
            }
            else if (int.Parse(lblUndoCount.Text) < 3)
            {
                lblUndoRemain.ForeColor = Color.Red;
            }
            else
            {
                lblUndoRemain.ForeColor = Color.DarkOrange;
            }

            if ()
        }

        void Tumbler(bool status)
        {
            if (status)
            {
                btnUndo.Show();
                btnPlus.Show();
                btnMulti.Show();
                btnReset.Show();
                lblUndoCount.Show();
                lblTargetNum.Show();
                lblUserNum.Show();
            }
            else
            {
                btnUndo.Hide();
                btnPlus.Hide();
                btnMulti.Hide();
                btnReset.Hide();
                lblUndoCount.Hide();
                lblTargetNum.Hide();
                lblUserNum.Hide();
            }
        }

        private void btnStartAgain_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            if (btnStartAgain.Text == "Начать")
            {
                Tumbler(true);
                btnStartAgain.Text = "Сначала";

            }
            else
            {
                userNum = 1;
                lblUserNum.Text = $"{userNum}";
            }

            lblTargetNum.Text = $"{rnd.Next(5, 101)}";
            undoNum.Clear();
            globalCount = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Tumbler(false);
            btnStartAgain.Text = "Начать";
            lblUndoCount.Text = "5";
            undoNum.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            globalCount++;
            undoCount++;
            undoNum.Add(userNum);
            userNum++;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            globalCount++;
            undoCount++;
            undoNum.Add(userNum);
            userNum *= 2;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            globalCount++;
            undoCount++;
            undoNum.Add(userNum);
            userNum = 1;
        }
    }
}
