namespace AkhmerovHomeWork
{
    partial class fDoubler
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
            this.lblUserNumLabel = new System.Windows.Forms.Label();
            this.lblTargetNumLabel = new System.Windows.Forms.Label();
            this.lblUndoCountLabel = new System.Windows.Forms.Label();
            this.lblUndoCount = new System.Windows.Forms.Label();
            this.lblUserNum = new System.Windows.Forms.Label();
            this.lblTargetNum = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStartAgain = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblCompTurnsLabel = new System.Windows.Forms.Label();
            this.lblUserTurnsLabel = new System.Windows.Forms.Label();
            this.lblCompTurns = new System.Windows.Forms.Label();
            this.lblUserTurns = new System.Windows.Forms.Label();
            this.lblWinLose = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblFinish = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserNumLabel
            // 
            this.lblUserNumLabel.AutoSize = true;
            this.lblUserNumLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserNumLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblUserNumLabel.Location = new System.Drawing.Point(257, 76);
            this.lblUserNumLabel.Name = "lblUserNumLabel";
            this.lblUserNumLabel.Size = new System.Drawing.Size(128, 23);
            this.lblUserNumLabel.TabIndex = 1;
            this.lblUserNumLabel.Text = "ВАШЕ ЧИСЛО:";
            // 
            // lblTargetNumLabel
            // 
            this.lblTargetNumLabel.AutoSize = true;
            this.lblTargetNumLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTargetNumLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTargetNumLabel.Location = new System.Drawing.Point(471, 76);
            this.lblTargetNumLabel.Name = "lblTargetNumLabel";
            this.lblTargetNumLabel.Size = new System.Drawing.Size(158, 23);
            this.lblTargetNumLabel.TabIndex = 2;
            this.lblTargetNumLabel.Text = "ЦЕЛЕВОЕ ЧИСЛО:";
            // 
            // lblUndoCountLabel
            // 
            this.lblUndoCountLabel.AutoSize = true;
            this.lblUndoCountLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUndoCountLabel.ForeColor = System.Drawing.Color.Green;
            this.lblUndoCountLabel.Location = new System.Drawing.Point(12, 76);
            this.lblUndoCountLabel.Name = "lblUndoCountLabel";
            this.lblUndoCountLabel.Size = new System.Drawing.Size(175, 23);
            this.lblUndoCountLabel.TabIndex = 3;
            this.lblUndoCountLabel.Text = "ОСТАЛОСЬ ОТМЕН:";
            // 
            // lblUndoCount
            // 
            this.lblUndoCount.AutoSize = true;
            this.lblUndoCount.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUndoCount.ForeColor = System.Drawing.Color.Black;
            this.lblUndoCount.Location = new System.Drawing.Point(192, 76);
            this.lblUndoCount.Name = "lblUndoCount";
            this.lblUndoCount.Size = new System.Drawing.Size(20, 23);
            this.lblUndoCount.TabIndex = 4;
            this.lblUndoCount.Text = "5";
            this.lblUndoCount.TextChanged += new System.EventHandler(this.lblUndoCount_TextChanged);
            // 
            // lblUserNum
            // 
            this.lblUserNum.AutoSize = true;
            this.lblUserNum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserNum.Location = new System.Drawing.Point(391, 76);
            this.lblUserNum.Name = "lblUserNum";
            this.lblUserNum.Size = new System.Drawing.Size(20, 23);
            this.lblUserNum.TabIndex = 5;
            this.lblUserNum.Text = "1";
            this.lblUserNum.TextChanged += new System.EventHandler(this.lblUserNum_TextChanged);
            // 
            // lblTargetNum
            // 
            this.lblTargetNum.AutoSize = true;
            this.lblTargetNum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTargetNum.Location = new System.Drawing.Point(632, 76);
            this.lblTargetNum.Name = "lblTargetNum";
            this.lblTargetNum.Size = new System.Drawing.Size(40, 23);
            this.lblTargetNum.TabIndex = 6;
            this.lblTargetNum.Text = "100";
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(200, 145);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(120, 60);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "Прибавить";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMulti.Location = new System.Drawing.Point(360, 145);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(120, 60);
            this.btnMulti.TabIndex = 8;
            this.btnMulti.Text = "Умножить";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUndo.Location = new System.Drawing.Point(70, 145);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(120, 60);
            this.btnUndo.TabIndex = 9;
            this.btnUndo.Text = "Отменить";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(70, 300);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(540, 50);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Вернуться в Главное меню";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(490, 145);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 60);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnStartAgain
            // 
            this.btnStartAgain.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartAgain.Location = new System.Drawing.Point(70, 243);
            this.btnStartAgain.Name = "btnStartAgain";
            this.btnStartAgain.Size = new System.Drawing.Size(265, 50);
            this.btnStartAgain.TabIndex = 12;
            this.btnStartAgain.Text = "Начать/Сначала";
            this.btnStartAgain.UseVisualStyleBackColor = true;
            this.btnStartAgain.Click += new System.EventHandler(this.btnStartAgain_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHelp.Location = new System.Drawing.Point(345, 243);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(265, 50);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "Справка";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblCompTurnsLabel
            // 
            this.lblCompTurnsLabel.AutoSize = true;
            this.lblCompTurnsLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompTurnsLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblCompTurnsLabel.Location = new System.Drawing.Point(12, 9);
            this.lblCompTurnsLabel.Name = "lblCompTurnsLabel";
            this.lblCompTurnsLabel.Size = new System.Drawing.Size(200, 23);
            this.lblCompTurnsLabel.TabIndex = 14;
            this.lblCompTurnsLabel.Text = "ХОДЫ КОМПЬЮТЕРА:";
            // 
            // lblUserTurnsLabel
            // 
            this.lblUserTurnsLabel.AutoSize = true;
            this.lblUserTurnsLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserTurnsLabel.ForeColor = System.Drawing.Color.Green;
            this.lblUserTurnsLabel.Location = new System.Drawing.Point(85, 41);
            this.lblUserTurnsLabel.Name = "lblUserTurnsLabel";
            this.lblUserTurnsLabel.Size = new System.Drawing.Size(127, 23);
            this.lblUserTurnsLabel.TabIndex = 15;
            this.lblUserTurnsLabel.Text = "ВАШИ ХОДЫ:";
            // 
            // lblCompTurns
            // 
            this.lblCompTurns.AutoSize = true;
            this.lblCompTurns.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompTurns.ForeColor = System.Drawing.Color.Black;
            this.lblCompTurns.Location = new System.Drawing.Point(218, 9);
            this.lblCompTurns.Name = "lblCompTurns";
            this.lblCompTurns.Size = new System.Drawing.Size(20, 23);
            this.lblCompTurns.TabIndex = 16;
            this.lblCompTurns.Text = "1";
            // 
            // lblUserTurns
            // 
            this.lblUserTurns.AutoSize = true;
            this.lblUserTurns.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserTurns.ForeColor = System.Drawing.Color.Black;
            this.lblUserTurns.Location = new System.Drawing.Point(218, 41);
            this.lblUserTurns.Name = "lblUserTurns";
            this.lblUserTurns.Size = new System.Drawing.Size(20, 23);
            this.lblUserTurns.TabIndex = 17;
            this.lblUserTurns.Text = "1";
            // 
            // lblWinLose
            // 
            this.lblWinLose.AutoSize = true;
            this.lblWinLose.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWinLose.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblWinLose.Location = new System.Drawing.Point(333, 41);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(197, 23);
            this.lblWinLose.TabIndex = 18;
            this.lblWinLose.Text = "ПОБЕДА/ПОРАЖЕНИЕ";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(337, 293);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(5, 5);
            this.btnFinish.TabIndex = 19;
            this.btnFinish.TabStop = false;
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFinish.ForeColor = System.Drawing.Color.Red;
            this.lblFinish.Location = new System.Drawing.Point(323, 18);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(114, 23);
            this.lblFinish.TabIndex = 20;
            this.lblFinish.Text = "НЕ ЧЕСТНАЯ";
            // 
            // fDoubler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 375);
            this.ControlBox = false;
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblWinLose);
            this.Controls.Add(this.lblUserTurns);
            this.Controls.Add(this.lblCompTurns);
            this.Controls.Add(this.lblUserTurnsLabel);
            this.Controls.Add(this.lblCompTurnsLabel);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnStartAgain);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblTargetNum);
            this.Controls.Add(this.lblUserNum);
            this.Controls.Add(this.lblUndoCount);
            this.Controls.Add(this.lblUndoCountLabel);
            this.Controls.Add(this.lblTargetNumLabel);
            this.Controls.Add(this.lblUserNumLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fDoubler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doubler";
            this.Load += new System.EventHandler(this.fDoubler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserNumLabel;
        private System.Windows.Forms.Label lblTargetNumLabel;
        private System.Windows.Forms.Label lblUndoCountLabel;
        private System.Windows.Forms.Label lblUndoCount;
        private System.Windows.Forms.Label lblUserNum;
        private System.Windows.Forms.Label lblTargetNum;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStartAgain;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblCompTurnsLabel;
        private System.Windows.Forms.Label lblUserTurnsLabel;
        private System.Windows.Forms.Label lblCompTurns;
        private System.Windows.Forms.Label lblUserTurns;
        private System.Windows.Forms.Label lblWinLose;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblFinish;
    }
}