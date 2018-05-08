namespace AkhmerovHomeWork
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class fGuessTheNumber : Form
    {
        fMain fm = new fMain();

        private int targetNum;
        private int userNum;
        private int userTurns;
        private int compTurns;

        List<int> tempUserNum = new List<int>();


        public fGuessTheNumber()
        {
            InitializeComponent();
        }

        private void fGuessTheNumber_Load(object sender, EventArgs e) // Загрузка формы
        {
            EndTumbler(false);
            StartTumbler(false);

            btnStart.Text = "Начать";

            lblFinish.Hide();
            btnFinish.Hide();
        }

        #region Кнопки

        private void btnStart_Click(object sender, EventArgs e) // Начать/Сначала
        {
            Random rnd = new Random();

            if (btnStart.Text == "Начать")
            {
                btnStart.Text = "Сначала";
            }

            targetNum = rnd.Next(1, 101);
            TabIndex = 1;
            compTurns = 1;
            userTurns = 0;

            tempUserNum.Clear();
            tbUserNum.Clear();

            lblCompTurns.Text = $"{CompSolve()}";

            EndTumbler(false);
            StartTumbler(true);

            lblUserNumStatus.Hide();
            lblFinish.Hide();
            btnFinish.Show();

            btnAddNum.Enabled = false;
        }

        private void btnAddNum_Click(object sender, EventArgs e) // Проверить
        {
            lblUserNumStatus.Show();
            if (userNum > targetNum)
            {
                lblUserNumStatus.ForeColor = Color.MediumBlue;
                lblUserNumStatus.Text = "Моё число меньше";
                userTurns++;
                tempUserNum.Add(userNum);
            }
            else if (userNum < targetNum)
            {
                lblUserNumStatus.ForeColor = Color.Red;
                lblUserNumStatus.Text = "Моё число больше";
                userTurns++;
                tempUserNum.Add(userNum);
            }
            else
            {
                lblUserTurnsLabel.ForeColor = userTurns > compTurns ? Color.Red : Color.ForestGreen;

                lblUserTurns.Text = $"{userTurns}";

                StartTumbler(false);
                EndTumbler(true);

                btnFinish.Hide();
            }

            btnAddNum.Enabled = false;
        }

        private void btnHelp_Click(object sender, EventArgs e) // Справка
        {
            MessageBox.Show("Цель проста: Компьютер загадал число от 1 до 100," +
                            "\nВаша цель угадать данное число за наименьшее число ходов." +
                            "\nКомпьютер будет подсказывать, больше ли загаданное число или меньше." +
                            "\nПо завершению будут показаны количество ваших и компьютерных ходов.");
        }

        private void btnReturn_Click(object sender, EventArgs e) // Возврат в Главное меню
        {
            Hide();
            fm.Show();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

            userNum = targetNum;
            if (!btnAddNum.Enabled)
            {
                btnAddNum.Enabled = true;
            }
            btnAddNum.PerformClick();
            lblFinish.Show();
            lblUserTurns.Text = lblCompTurns.Text;
            btnAddNum.Enabled = false;
        }

        #endregion

        #region Поля ввода

        private void tbUserNum_TextChanged(object sender, EventArgs e) // Изменение пользовательского числа в поле
        {
            if (int.TryParse(tbUserNum.Text, out userNum))
            {
                if (userNum < 1 || userNum > 100)
                {
                    tbUserNum.Clear();
                }
                else
                {
                    btnAddNum.Enabled = !tempUserNum.Contains(userNum);
                }
            }
            else
            {
                btnAddNum.Enabled = false;
                tbUserNum.Clear();
            }
        }

        #endregion

        #region Вспомогательные методы

        void StartTumbler(bool status) // Начальный переключатель
        {
            if (status)
            {
                btnAddNum.Show();
                tbUserNum.Show();
            }
            else
            {
                btnAddNum.Hide();
                tbUserNum.Hide();
                lblUserNumStatus.Hide();
            }
        }

        void EndTumbler(bool status) // Конечный переключатель
        {
            if (status)
            {
                lblUserTurns.Show();
                lblUserTurnsLabel.Show();
                lblCompTurns.Show();
                lblCompTurnsLabel.Show();
                lblWinLose.Show();
            }
            else
            {
                lblUserTurns.Hide();
                lblUserTurnsLabel.Hide();
                lblCompTurns.Hide();
                lblCompTurnsLabel.Hide();
                lblWinLose.Hide();
            }
        }

        int CompSolve() // Решение задачи компьютером;
        {
            var compNum = 50;
            var temp = compNum;

            while (compNum != targetNum)
            {
                if (compNum > targetNum)
                {
                    if (Math.Abs(temp / 2) == 0)
                    {
                        compNum--;
                    }
                    else
                    {
                        compNum -= Math.Abs(temp /= 2);
                    }
                }
                else
                {
                    if (Math.Abs(temp / 2) == 0)
                    {
                        compNum++;
                    }
                    else
                    {
                        compNum += Math.Abs(temp /= 2);
                    }
                }

                compTurns++;
            }

            return compTurns;
        }

        #endregion

        

        

        

        

        

        

        

        

        
    }
}
