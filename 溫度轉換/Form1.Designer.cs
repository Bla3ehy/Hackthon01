namespace 溫度轉換
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RdbToF = new System.Windows.Forms.RadioButton();
            this.RdbToC = new System.Windows.Forms.RadioButton();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.LblAns = new System.Windows.Forms.Label();
            this.TbxEnter = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RdbToC);
            this.panel1.Controls.Add(this.RdbToF);
            this.panel1.Location = new System.Drawing.Point(89, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // RdbToF
            // 
            this.RdbToF.AutoSize = true;
            this.RdbToF.Location = new System.Drawing.Point(21, 23);
            this.RdbToF.Name = "RdbToF";
            this.RdbToF.Size = new System.Drawing.Size(133, 19);
            this.RdbToF.TabIndex = 0;
            this.RdbToF.TabStop = true;
            this.RdbToF.Text = "攝氏轉換為華氏";
            this.RdbToF.UseVisualStyleBackColor = true;
            // 
            // RdbToC
            // 
            this.RdbToC.AutoSize = true;
            this.RdbToC.Location = new System.Drawing.Point(21, 64);
            this.RdbToC.Name = "RdbToC";
            this.RdbToC.Size = new System.Drawing.Size(133, 19);
            this.RdbToC.TabIndex = 1;
            this.RdbToC.TabStop = true;
            this.RdbToC.Text = "華氏轉換為攝氏";
            this.RdbToC.UseVisualStyleBackColor = true;
            // 
            // BtnConvert
            // 
            this.BtnConvert.Location = new System.Drawing.Point(632, 245);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(75, 36);
            this.BtnConvert.TabIndex = 1;
            this.BtnConvert.Text = "轉換";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(366, 110);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(40, 40);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(430, 110);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(40, 40);
            this.Btn2.TabIndex = 1;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(491, 110);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(40, 40);
            this.Btn3.TabIndex = 1;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(366, 173);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(40, 40);
            this.Btn4.TabIndex = 1;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(430, 173);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(40, 40);
            this.Btn5.TabIndex = 1;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(491, 173);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(40, 40);
            this.Btn6.TabIndex = 1;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(366, 241);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(40, 40);
            this.Btn7.TabIndex = 1;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(430, 241);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(40, 40);
            this.Btn8.TabIndex = 1;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn9
            // 
            this.Btn9.Location = new System.Drawing.Point(491, 241);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(40, 40);
            this.Btn9.TabIndex = 1;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(751, 245);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 36);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "清除";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Btn0
            // 
            this.Btn0.Location = new System.Drawing.Point(366, 301);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(40, 40);
            this.Btn0.TabIndex = 1;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.Location = new System.Drawing.Point(430, 301);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(40, 40);
            this.BtnDot.TabIndex = 1;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = true;
            this.BtnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // LblAns
            // 
            this.LblAns.AutoSize = true;
            this.LblAns.Location = new System.Drawing.Point(632, 335);
            this.LblAns.Name = "LblAns";
            this.LblAns.Size = new System.Drawing.Size(45, 15);
            this.LblAns.TabIndex = 2;
            this.LblAns.Text = "結果 :";
            // 
            // TbxEnter
            // 
            this.TbxEnter.Location = new System.Drawing.Point(635, 137);
            this.TbxEnter.Name = "TbxEnter";
            this.TbxEnter.Size = new System.Drawing.Size(205, 25);
            this.TbxEnter.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 603);
            this.Controls.Add(this.TbxEnter);
            this.Controls.Add(this.LblAns);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnConvert);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RdbToC;
        private System.Windows.Forms.RadioButton RdbToF;
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Label LblAns;
        private System.Windows.Forms.TextBox TbxEnter;
    }
}

