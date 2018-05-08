using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkhmerovHomeWork
{

    public partial class fDoubler : Form
    {
        fMain fm = new fMain();
        static List<int> undoNum = new List<int>();
        static int userNum;
        static int undoCount;
        static int compTurns;
        static int targetNum;
        static int userTurns;

        public fDoubler()
        {
            InitializeComponent();
        }

        private void fDoubler_Load(object sender, EventArgs e) // Загрузка формы
        {
            StartTumbler(false);
            EndTumbler(false);

            btnStartAgain.Text = "Начать";

            btnUndo.Enabled = false;

            lblFinish.Hide();
        }

        #region Кнопки

        private void btnStartAgain_Click(object sender, EventArgs e) // Начать/Сначала
        {
            Random rnd = new Random();

            if (btnStartAgain.Text == "Начать")
            {
                StartTumbler(true);
                EndTumbler(false);
                btnStartAgain.Text = "Сначала";
                lblFinish.Hide();
            }

            undoNum.Clear();
            userTurns = 0;
            userNum = 1;
            targetNum = rnd.Next(5, 101);

            lblCompTurns.Text = $"{CompSolve()}";
            lblTargetNum.Text = $"{targetNum}";
            lblUserNum.Text = $"{userNum}";

            btnUndo.Enabled = false;

            if (undoCount != 5)
            {
                undoCount = 5;
                lblUndoCount.Text = $"{undoCount}";
            }
        }

        private void btnBack_Click(object sender, EventArgs e) // Возврат в Главное меню
        {
            StartTumbler(false);
            EndTumbler(false);
            btnStartAgain.Text = "Начать";
            Hide();
            fm.Show();
        }

        private void btn_Click(object sender, EventArgs e) // Клик по кнопкам (Отменить, Прибавить, Умножить, Сбросить)
        {
            if (sender as Button == btnUndo) // Отменить
            {
                userNum = undoNum.Last();
                undoNum.RemoveAt(undoNum.Count - 1);
                undoCount--;
            }
            else
            {
                undoNum.Add(userNum);

                if (sender as Button == btnPlus) // Прибавить
                {
                    userNum++;
                }
                else if (sender as Button == btnMulti) // Умножить
                {
                    userNum *= 2;
                }
                else if (sender as Button == btnReset) // Сбросить
                {
                    userNum = 1;
                }
            }

            lblUndoCount.Text = $"{undoCount}";
            userTurns++;
            lblUserNum.Text = $"{userNum}";
            
        }

        private void btnHelp_Click(object sender, EventArgs e) // Справка
        {
            MessageBox.Show("Ваша цель добиться получения ЦЕЛЕВОГО числа путем добавления/умножения ВАШЕГО числа." +
                            "\nДополнительная задача - добиться победы за столько же или меньше ходов, сколько сделал компьютер (Они отобразятся после победы/проигрыша)." +
                            "\nКаждый ход (в том числе сброс числа и отмена действий) добавляют вам количество ходов.\n" +
                            "\nКнопка \"Умножить\" - умножает ваше число на 2." +
                            "\nКнопка \"Прибавить\" - прибавляет к вашему число 1." +
                            "\nКнопка \"Отменить\" - отменяет ваши последние действия (всего дано 5 попыток)." +
                            "\nКнопка \"Сбросить\" - сбрасывает ваше число до 1.\n" +
                            "\nДля начала нажмите кнопку \"Начать\"." +
                            "\nДля того, чтобы переиграть - нажмите кнопку \"Сначала\"(появится после начала игры)");
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            userNum = targetNum;
            userTurns = compTurns;
            lblUserNum.Text = $"{userNum}";
            lblUserTurns.Text = $"{userTurns}";
            lblFinish.Show();
        }

        #endregion

        #region Заголовки

        private void lblUndoCount_TextChanged(object sender, EventArgs e) // Изменение текста попыток отмен
        {
            if (undoCount == 5)
            {
                lblUndoCountLabel.ForeColor = Color.Green;
            }
            else if (undoCount < 2)
            {
                lblUndoCountLabel.ForeColor = Color.Red;

                if (undoCount < 1)
                {
                    btnUndo.Enabled = false;
                }
            }
            else if (undoCount > 1 && undoCount < 5)
            {
                lblUndoCountLabel.ForeColor = Color.DarkOrange;
            }
        }

        private void lblUserNum_TextChanged(object sender, EventArgs e) // Изменение пользовательского числа
        {
            if (undoNum.Count > 0 && undoCount > 0)
            {
                btnUndo.Enabled = true;
            }
            else
            {
                btnUndo.Enabled = false;
            }

            if (userNum >= targetNum)
            {
                StartTumbler(false);
                EndTumbler(true);

                btnStartAgain.Text = "Начать";
                lblUserTurns.Text = $"{userTurns}";
                lblUserTurnsLabel.ForeColor = userTurns > compTurns ? Color.Red : Color.DarkGreen;

                if (userNum > targetNum)
                {
                    lblWinLose.ForeColor = Color.Red;
                    lblWinLose.Text = "ПРОИГРЫШ!";
                }
                else
                {
                    lblWinLose.ForeColor = Color.DarkGreen;
                    lblWinLose.Text = "ПОБЕДА!";
                }
            }
        }

        #endregion

        #region Вспомогательные методы

        void StartTumbler(bool status) // Начальный Переключатель
        {
            if (status)
            {
                btnUndo.Show();
                btnPlus.Show();
                btnMulti.Show();
                btnReset.Show();
                btnFinish.Show();

                lblUndoCount.Show();
                lblUndoCountLabel.Show();
                lblTargetNum.Show();
                lblTargetNumLabel.Show();
                lblUserNum.Show();
                lblUserNumLabel.Show();
            }
            else
            {
                btnUndo.Hide();
                btnPlus.Hide();
                btnMulti.Hide();
                btnReset.Hide();
                btnFinish.Hide();

                lblUndoCount.Hide();
                lblUndoCountLabel.Hide();
                lblTargetNum.Hide();
                lblTargetNumLabel.Hide();
                lblUserNum.Hide();
                lblUserNumLabel.Hide();
            }
        }

        void EndTumbler(bool status) // Конечный Переключатель
        {
            if (status)
            {
                lblCompTurnsLabel.Show();
                lblCompTurns.Show();
                lblUserTurnsLabel.Show();
                lblUserTurns.Show();
                lblWinLose.Show();
            }
            else
            {
                lblCompTurnsLabel.Hide();
                lblCompTurns.Hide();
                lblUserTurnsLabel.Hide();
                lblUserTurns.Hide();
                lblWinLose.Hide();
            }
        }

        int CompSolve() // Решение игры компьютером
        {
            compTurns = 0;
            var finishNum = targetNum;
            while (finishNum != 1)
            {
                if (finishNum % 2 != 0)
                {
                    finishNum--;
                    compTurns++;
                }
                else
                {
                    finishNum /= 2;
                    compTurns++;
                }
            }

            return compTurns;
        }

        #endregion

        
    }
}
