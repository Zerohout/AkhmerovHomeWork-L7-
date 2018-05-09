namespace AkhmerovHomeWork
{
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class fVacation : Form
    {
        bool nameCheck;
        bool dateCheck;
        bool anotherCheck;

        public fVacation()
        {
            InitializeComponent();
        }

        private void fVacation_Load(object sender, EventArgs e) // Загрузка формы
        {
            LabelTumbler(false);
            TextBoxTumbler(true);
            btnDoIt.Enabled = false;
        }

        #region Кнопки

        private void btnDoIt_Click(object sender, EventArgs e) // Сделать/Заново
        {
            if (btnDoIt.Text == "Сделать")
            {
                TextBoxTumbler(false);
                LabelTumbler(true);

                btnDoIt.Text = "Заново";
                lblOrg.Text = tbOrg.Text;
                lblDirName.Text = tbDirName.Text;
                lblPos.Text = tbPos.Text;
                lblWorkName1.Text = tbWorkName1.Text;
                lblFrom.Text = tbFrom.Text;
                lblTo.Text = tbTo.Text;
                lblDate.Text = tbDate.Text;
                lblWorkName2.Text = tbWorkName2.Text;
            }
            else
            {
                TextBoxTumbler(true);
                LabelTumbler(false);

                btnDoIt.Text = "Сделать";
                tbOrg.Text = "Организация";
                tbDirName.Text = "Фамилия И.О.(Дат.пад.)";
                tbPos.Text = "Должность работника";
                tbWorkName1.Text = "Фамилия И.О.(Род.пад.)";
                tbFrom.Text = "ДД.ММ.ГГГГ";
                tbTo.Text = "ДД.ММ.ГГГГ";
                tbDate.Text = "ДД.ММ.ГГГГ";
                tbWorkName2.Text = "Фамилия И.О.(Им.пад)";
            }
        }

        private void btnReturn_Click(object sender, EventArgs e) // Возват в Главное меню
        {
            LabelTumbler(false);
            TextBoxTumbler(true);
            var fm = new fMain();
            Hide();
            fm.Show();
        }

        #endregion

        #region Текстовые поля

         private void tbTextChanged(object sender, EventArgs e) // Обработка текстовых полей
        {
            var regexName = new Regex("[А-Я]+[а-я]{4,15} [А-Я].[А-Я].");
            var regexDate = new Regex("[0-9]{2}.[0-9]{2}.[0-9]{4}");


            if (sender as TextBox == tbDirName || sender as TextBox == tbWorkName1 || sender as TextBox == tbWorkName2)
                // Текстовые поля, содержащие ИМЕНА
            {
                if (!regexName.IsMatch(tbDirName.Text) || !regexName.IsMatch(tbWorkName1.Text) || !regexName.IsMatch(tbWorkName2.Text))
                {
                    btnDoIt.Enabled = false;
                    anotherCheck = false;
                }
                else if (regexName.IsMatch(tbDirName.Text) && regexName.IsMatch(tbWorkName1.Text) && regexName.IsMatch(tbWorkName2.Text))
                {
                    nameCheck = true;
                }
            }
            else if (sender as TextBox == tbFrom || sender as TextBox == tbTo || sender as TextBox == tbDate)
                // Текстовые поля, содержащие ДАТЫ
            {
                if (!regexDate.IsMatch(tbFrom.Text) || !regexDate.IsMatch(tbTo.Text) || !regexDate.IsMatch(tbDate.Text))
                {
                    btnDoIt.Enabled = false;
                    anotherCheck = false;
                }
                else if (regexDate.IsMatch(tbFrom.Text) && regexDate.IsMatch(tbTo.Text) && regexDate.IsMatch(tbDate.Text))
                {
                    dateCheck = true;
                }
            }
            else if (sender as TextBox == tbOrg || sender as TextBox == tbPos)
                // Текстовые поля, содержащие ОРГАНИЗАЦИЮ и ДОЛЖНОСТЬ
            {
                if (tbOrg.Text == "Организация" || tbPos.Text == "Должность работника")
                {
                    btnDoIt.Enabled = false;
                    anotherCheck = false;
                }
                else
                {
                    anotherCheck = true;
                }
            }

            if (nameCheck && dateCheck && anotherCheck)
            {
                btnDoIt.Enabled = true;
            }
        }

        private void tbDoubleClick(object sender, EventArgs e) // Обработка двойного клика по текстовым полям
        {
            (sender as TextBox).SelectAll();
        }

        #endregion

        #region Вспомогательные методы

        void LabelTumbler(bool status) // Переключатель заголовков
        {
            if (status)
            {
                lblOrg.Show();
                lblDirName.Show();
                lblPos.Show();
                lblWorkName1.Show();
                lblFrom.Show();
                lblTo.Show();
                lblDate.Show();
                lblWorkName2.Show();
            }
            else
            {
                lblOrg.Hide();
                lblDirName.Hide();
                lblPos.Hide();
                lblWorkName1.Hide();
                lblFrom.Hide();
                lblTo.Hide();
                lblDate.Hide();
                lblWorkName2.Hide();
            }
        }

        void TextBoxTumbler(bool status) // Переключатель полей ввода текста
        {
            if (status)
            {
                tbOrg.Show();
                tbDirName.Show();
                tbPos.Show();
                tbWorkName1.Show();
                tbFrom.Show();
                tbTo.Show();
                tbDate.Show();
                tbWorkName2.Show();
            }
            else
            {
                tbOrg.Hide();
                tbDirName.Hide();
                tbPos.Hide();
                tbWorkName1.Hide();
                tbFrom.Hide();
                tbTo.Hide();
                tbDate.Hide();
                tbWorkName2.Hide();
            }
        }

        #endregion
        

        

        

        
    }
}
