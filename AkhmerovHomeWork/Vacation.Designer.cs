namespace AkhmerovHomeWork
{
    partial class fVacation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPos = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbWorkName1 = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbDirName = new System.Windows.Forms.TextBox();
            this.tbOrg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbWorkName2 = new System.Windows.Forms.TextBox();
            this.btnDoIt = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOrg = new System.Windows.Forms.Label();
            this.lblDirName = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.lblWorkName1 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWorkName2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPos
            // 
            this.tbPos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPos.Location = new System.Drawing.Point(338, 84);
            this.tbPos.Name = "tbPos";
            this.tbPos.Size = new System.Drawing.Size(187, 26);
            this.tbPos.TabIndex = 2;
            this.tbPos.Text = "Должность работника";
            this.tbPos.TextChanged += new System.EventHandler(this.tbTextChanged);
            this.tbPos.DoubleClick += new System.EventHandler(this.tbDoubleClick);
            // 
            // tbTo
            // 
            this.tbTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTo.Location = new System.Drawing.Point(240, 248);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(103, 26);
            this.tbTo.TabIndex = 5;
            this.tbTo.Text = "ДД.ММ.ГГГГ";
            this.tbTo.TextChanged += new System.EventHandler(this.tbTextChanged);
            this.tbTo.DoubleClick += new System.EventHandler(this.tbDoubleClick);
            // 
            // tbWorkName1
            // 
            this.tbWorkName1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWorkName1.Location = new System.Drawing.Point(312, 116);
            this.tbWorkName1.Name = "tbWorkName1";
            this.tbWorkName1.Size = new System.Drawing.Size(180, 26);
            this.tbWorkName1.TabIndex = 3;
            this.tbWorkName1.Text = "Фамилия И.О. (Род.пад.)";
            this.tbWorkName1.TextChanged += new System.EventHandler(this.tbTextChanged);
            this.tbWorkName1.DoubleClick += new System.EventHandler(this.tbDoubleClick);
            // 
            // tbFrom
            // 
            this.tbFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFrom.Location = new System.Drawing.Point(87, 248);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(103, 26);
            this.tbFrom.TabIndex = 4;
            this.tbFrom.Text = "ДД.ММ.ГГГГ";
            this.tbFrom.TextChanged += new System.EventHandler(this.tbTextChanged);
            this.tbFrom.DoubleClick += new System.EventHandler(this.tbDoubleClick);
            // 
            // tbDirName
            // 
            this.tbDirName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDirName.Location = new System.Drawing.Point(312, 52);
            this.tbDirName.Name = "tbDirName";
            this.tbDirName.Size = new System.Drawing.Size(180, 26);
            this.tbDirName.TabIndex = 1;
            this.tbDirName.Text = "Фамилия И.О. (Дат.пад.)";
            this.tbDirName.TextChanged += new System.EventHandler(this.tbTextChanged);
            this.tbDirName.DoubleClick += new System.EventHandler(this.tbDoubleClick);
            // 
            // tbOrg
            // 
            this.tbOrg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOrg.Location = new System.Drawing.Point(395, 20);
            this.tbOrg.Name = "tbOrg";
            this.tbOrg.Size = new System.Drawing.Size(130, 26);
            this.tbOrg.TabIndex = 0;
            this.tbOrg.Text = "Организация";
            this.tbOrg.TextChanged += new System.EventHandler(this.tbTextChanged);
            this.tbOrg.DoubleClick += new System.EventHandler(this.tbDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(308, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Директору";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(308, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "от";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(171, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "заявление.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(440, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Прошу предоставить мне ежегодный очередной оплачиваемый";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "отпуск с ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(196, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "г. по";
            // 
            // tbDate
            // 
            this.tbDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDate.Location = new System.Drawing.Point(16, 313);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(103, 26);
            this.tbDate.TabIndex = 6;
            this.tbDate.Text = "ДД.ММ.ГГГГ";
            this.tbDate.TextChanged += new System.EventHandler(this.tbTextChanged);
            this.tbDate.DoubleClick += new System.EventHandler(this.tbDoubleClick);
            // 
            // tbWorkName2
            // 
            this.tbWorkName2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWorkName2.Location = new System.Drawing.Point(345, 313);
            this.tbWorkName2.Name = "tbWorkName2";
            this.tbWorkName2.Size = new System.Drawing.Size(180, 26);
            this.tbWorkName2.TabIndex = 7;
            this.tbWorkName2.Text = "Фамилия И.О. (Им.пад.)";
            this.tbWorkName2.TextChanged += new System.EventHandler(this.tbTextChanged);
            this.tbWorkName2.DoubleClick += new System.EventHandler(this.tbDoubleClick);
            // 
            // btnDoIt
            // 
            this.btnDoIt.Location = new System.Drawing.Point(16, 379);
            this.btnDoIt.Name = "btnDoIt";
            this.btnDoIt.Size = new System.Drawing.Size(509, 35);
            this.btnDoIt.TabIndex = 8;
            this.btnDoIt.Text = "Сделать";
            this.btnDoIt.UseVisualStyleBackColor = true;
            this.btnDoIt.Click += new System.EventHandler(this.btnDoIt_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(16, 420);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(509, 35);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Вернуться в Главное меню";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(349, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "г.";
            // 
            // lblOrg
            // 
            this.lblOrg.AutoSize = true;
            this.lblOrg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrg.Location = new System.Drawing.Point(395, 23);
            this.lblOrg.Name = "lblOrg";
            this.lblOrg.Size = new System.Drawing.Size(98, 19);
            this.lblOrg.TabIndex = 17;
            this.lblOrg.Text = "Организация";
            // 
            // lblDirName
            // 
            this.lblDirName.AutoSize = true;
            this.lblDirName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDirName.Location = new System.Drawing.Point(308, 55);
            this.lblDirName.Name = "lblDirName";
            this.lblDirName.Size = new System.Drawing.Size(107, 19);
            this.lblDirName.TabIndex = 18;
            this.lblDirName.Text = "Фамилия И.О.";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPos.Location = new System.Drawing.Point(341, 87);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(159, 19);
            this.lblPos.TabIndex = 19;
            this.lblPos.Text = "Должность работника";
            // 
            // lblWorkName1
            // 
            this.lblWorkName1.AutoSize = true;
            this.lblWorkName1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkName1.Location = new System.Drawing.Point(308, 119);
            this.lblWorkName1.Name = "lblWorkName1";
            this.lblWorkName1.Size = new System.Drawing.Size(107, 19);
            this.lblWorkName1.TabIndex = 20;
            this.lblWorkName1.Text = "Фамилия И.О.";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrom.Location = new System.Drawing.Point(87, 251);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(103, 19);
            this.lblFrom.TabIndex = 21;
            this.lblFrom.Text = "ДД.ММ.ГГГГ";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTo.Location = new System.Drawing.Point(240, 251);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(103, 19);
            this.lblTo.TabIndex = 22;
            this.lblTo.Text = "ДД.ММ.ГГГГ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Location = new System.Drawing.Point(16, 316);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(103, 19);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "ДД.ММ.ГГГГ";
            // 
            // lblWorkName2
            // 
            this.lblWorkName2.AutoSize = true;
            this.lblWorkName2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkName2.Location = new System.Drawing.Point(341, 316);
            this.lblWorkName2.Name = "lblWorkName2";
            this.lblWorkName2.Size = new System.Drawing.Size(107, 19);
            this.lblWorkName2.TabIndex = 24;
            this.lblWorkName2.Text = "Фамилия И.О.";
            // 
            // fVacation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 471);
            this.ControlBox = false;
            this.Controls.Add(this.lblWorkName2);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblWorkName1);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.lblDirName);
            this.Controls.Add(this.lblOrg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDoIt);
            this.Controls.Add(this.tbWorkName2);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOrg);
            this.Controls.Add(this.tbDirName);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.tbWorkName1);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbPos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fVacation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacation";
            this.Load += new System.EventHandler(this.fVacation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPos;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbWorkName1;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbDirName;
        private System.Windows.Forms.TextBox tbOrg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbWorkName2;
        private System.Windows.Forms.Button btnDoIt;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOrg;
        private System.Windows.Forms.Label lblDirName;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Label lblWorkName1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblWorkName2;
    }
}