namespace AkhmerovHomeWork
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDoubler = new System.Windows.Forms.Button();
            this.btnGuessTheNum = new System.Windows.Forms.Button();
            this.btnVacation = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoubler
            // 
            this.btnDoubler.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDoubler.Location = new System.Drawing.Point(150, 30);
            this.btnDoubler.Name = "btnDoubler";
            this.btnDoubler.Size = new System.Drawing.Size(250, 80);
            this.btnDoubler.TabIndex = 0;
            this.btnDoubler.Text = "Игра \"Удвоитель\"";
            this.btnDoubler.UseVisualStyleBackColor = true;
            this.btnDoubler.Click += new System.EventHandler(this.btnDoubler_Click);
            // 
            // btnGuessTheNum
            // 
            this.btnGuessTheNum.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGuessTheNum.Location = new System.Drawing.Point(150, 120);
            this.btnGuessTheNum.Name = "btnGuessTheNum";
            this.btnGuessTheNum.Size = new System.Drawing.Size(250, 80);
            this.btnGuessTheNum.TabIndex = 1;
            this.btnGuessTheNum.Text = "Игра \"Угадай число\"";
            this.btnGuessTheNum.UseVisualStyleBackColor = true;
            this.btnGuessTheNum.Click += new System.EventHandler(this.btnGuessTheNum_Click);
            // 
            // btnVacation
            // 
            this.btnVacation.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVacation.Location = new System.Drawing.Point(150, 210);
            this.btnVacation.Name = "btnVacation";
            this.btnVacation.Size = new System.Drawing.Size(250, 80);
            this.btnVacation.TabIndex = 2;
            this.btnVacation.Text = "Заявление на отпуск";
            this.btnVacation.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(150, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(250, 80);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVacation);
            this.Controls.Add(this.btnGuessTheNum);
            this.Controls.Add(this.btnDoubler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoubler;
        private System.Windows.Forms.Button btnGuessTheNum;
        private System.Windows.Forms.Button btnVacation;
        private System.Windows.Forms.Button btnExit;
    }
}

