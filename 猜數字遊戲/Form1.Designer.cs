namespace 猜數字遊戲
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnAnswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxGuess = new System.Windows.Forms.TextBox();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnRestart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxHistory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(97, 85);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(93, 37);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "開始遊戲";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnAnswer
            // 
            this.BtnAnswer.Location = new System.Drawing.Point(97, 178);
            this.BtnAnswer.Name = "BtnAnswer";
            this.BtnAnswer.Size = new System.Drawing.Size(93, 37);
            this.BtnAnswer.TabIndex = 0;
            this.BtnAnswer.Text = "看答案";
            this.BtnAnswer.UseVisualStyleBackColor = true;
            this.BtnAnswer.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "輸入 :";
            // 
            // TbxGuess
            // 
            this.TbxGuess.Location = new System.Drawing.Point(97, 435);
            this.TbxGuess.Name = "TbxGuess";
            this.TbxGuess.Size = new System.Drawing.Size(249, 25);
            this.TbxGuess.TabIndex = 2;
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(97, 516);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(104, 37);
            this.BtnCheck.TabIndex = 3;
            this.BtnCheck.Text = "檢查答案";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnRestart
            // 
            this.BtnRestart.Location = new System.Drawing.Point(223, 516);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(100, 37);
            this.BtnRestart.TabIndex = 3;
            this.BtnRestart.Text = "放棄重來";
            this.BtnRestart.UseVisualStyleBackColor = true;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "遊戲歷程";
            // 
            // TbxHistory
            // 
            this.TbxHistory.Location = new System.Drawing.Point(535, 93);
            this.TbxHistory.Multiline = true;
            this.TbxHistory.Name = "TbxHistory";
            this.TbxHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbxHistory.Size = new System.Drawing.Size(413, 501);
            this.TbxHistory.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 628);
            this.Controls.Add(this.TbxHistory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.TbxGuess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAnswer);
            this.Controls.Add(this.BtnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxGuess;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnRestart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxHistory;
    }
}

