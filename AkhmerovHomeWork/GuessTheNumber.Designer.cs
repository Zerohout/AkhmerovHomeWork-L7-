namespace AkhmerovHomeWork
{
    partial class fGuessTheNumber
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAddNum = new System.Windows.Forms.Button();
            this.tbUserNum = new System.Windows.Forms.TextBox();
            this.lblUserNumStatus = new System.Windows.Forms.Label();
            this.lblUserTurnsLabel = new System.Windows.Forms.Label();
            this.lblCompTurnsLabel = new System.Windows.Forms.Label();
            this.lblWinLose = new System.Windows.Forms.Label();
            this.lblCompTurns = new System.Windows.Forms.Label();
            this.lblUserTurns = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblFinish = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(12, 127);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(245, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Начать/Сначала";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturn.Location = new System.Drawing.Point(12, 183);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(245, 50);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Вернуться в Главное меню";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHelp.Location = new System.Drawing.Point(263, 127);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(88, 106);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Справка";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAddNum
            // 
            this.btnAddNum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNum.Location = new System.Drawing.Point(12, 48);
            this.btnAddNum.Name = "btnAddNum";
            this.btnAddNum.Size = new System.Drawing.Size(103, 61);
            this.btnAddNum.TabIndex = 3;
            this.btnAddNum.Text = "Проверить";
            this.btnAddNum.UseVisualStyleBackColor = true;
            this.btnAddNum.Click += new System.EventHandler(this.btnAddNum_Click);
            // 
            // tbUserNum
            // 
            this.tbUserNum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserNum.Location = new System.Drawing.Point(12, 12);
            this.tbUserNum.Name = "tbUserNum";
            this.tbUserNum.Size = new System.Drawing.Size(103, 30);
            this.tbUserNum.TabIndex = 1;
            this.tbUserNum.TextChanged += new System.EventHandler(this.tbUserNum_TextChanged);
            // 
            // lblUserNumStatus
            // 
            this.lblUserNumStatus.AutoSize = true;
            this.lblUserNumStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserNumStatus.ForeColor = System.Drawing.Color.Red;
            this.lblUserNumStatus.Location = new System.Drawing.Point(121, 15);
            this.lblUserNumStatus.Name = "lblUserNumStatus";
            this.lblUserNumStatus.Size = new System.Drawing.Size(37, 23);
            this.lblUserNumStatus.TabIndex = 5;
            this.lblUserNumStatus.Text = "> <";
            // 
            // lblUserTurnsLabel
            // 
            this.lblUserTurnsLabel.AutoSize = true;
            this.lblUserTurnsLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserTurnsLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblUserTurnsLabel.Location = new System.Drawing.Point(194, 86);
            this.lblUserTurnsLabel.Name = "lblUserTurnsLabel";
            this.lblUserTurnsLabel.Size = new System.Drawing.Size(127, 23);
            this.lblUserTurnsLabel.TabIndex = 6;
            this.lblUserTurnsLabel.Text = "ВАШИ ХОДЫ:";
            // 
            // lblCompTurnsLabel
            // 
            this.lblCompTurnsLabel.AutoSize = true;
            this.lblCompTurnsLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompTurnsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCompTurnsLabel.Location = new System.Drawing.Point(121, 48);
            this.lblCompTurnsLabel.Name = "lblCompTurnsLabel";
            this.lblCompTurnsLabel.Size = new System.Drawing.Size(200, 23);
            this.lblCompTurnsLabel.TabIndex = 7;
            this.lblCompTurnsLabel.Text = "ХОДЫ КОМПЬЮТЕРА:";
            // 
            // lblWinLose
            // 
            this.lblWinLose.AutoSize = true;
            this.lblWinLose.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWinLose.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWinLose.Location = new System.Drawing.Point(265, 15);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(94, 23);
            this.lblWinLose.TabIndex = 8;
            this.lblWinLose.Text = "ПОБЕДА!!!";
            // 
            // lblCompTurns
            // 
            this.lblCompTurns.AutoSize = true;
            this.lblCompTurns.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompTurns.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCompTurns.Location = new System.Drawing.Point(321, 48);
            this.lblCompTurns.Name = "lblCompTurns";
            this.lblCompTurns.Size = new System.Drawing.Size(30, 23);
            this.lblCompTurns.TabIndex = 9;
            this.lblCompTurns.Text = "10";
            // 
            // lblUserTurns
            // 
            this.lblUserTurns.AutoSize = true;
            this.lblUserTurns.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserTurns.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblUserTurns.Location = new System.Drawing.Point(321, 86);
            this.lblUserTurns.Name = "lblUserTurns";
            this.lblUserTurns.Size = new System.Drawing.Size(30, 23);
            this.lblUserTurns.TabIndex = 10;
            this.lblUserTurns.Text = "10";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(257, 177);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(5, 5);
            this.btnFinish.TabIndex = 20;
            this.btnFinish.TabStop = false;
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFinish.ForeColor = System.Drawing.Color.Red;
            this.lblFinish.Location = new System.Drawing.Point(157, 15);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(114, 23);
            this.lblFinish.TabIndex = 21;
            this.lblFinish.Text = "НЕ ЧЕСТНАЯ";
            // 
            // fGuessTheNumber
            // 
            this.AcceptButton = this.btnAddNum;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 246);
            this.ControlBox = false;
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblUserTurns);
            this.Controls.Add(this.lblCompTurns);
            this.Controls.Add(this.lblWinLose);
            this.Controls.Add(this.lblCompTurnsLabel);
            this.Controls.Add(this.lblUserTurnsLabel);
            this.Controls.Add(this.lblUserNumStatus);
            this.Controls.Add(this.tbUserNum);
            this.Controls.Add(this.btnAddNum);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fGuessTheNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuessTheNumber";
            this.Load += new System.EventHandler(this.fGuessTheNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAddNum;
        private System.Windows.Forms.TextBox tbUserNum;
        private System.Windows.Forms.Label lblUserNumStatus;
        private System.Windows.Forms.Label lblUserTurnsLabel;
        private System.Windows.Forms.Label lblCompTurnsLabel;
        private System.Windows.Forms.Label lblWinLose;
        private System.Windows.Forms.Label lblCompTurns;
        private System.Windows.Forms.Label lblUserTurns;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblFinish;
    }
}