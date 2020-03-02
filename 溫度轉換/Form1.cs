﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 溫度轉換
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TbxEnter.AppendText("1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TbxEnter.AppendText("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TbxEnter.AppendText("3");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TbxEnter.AppendText("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TbxEnter.AppendText("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TbxEnter.AppendText("6");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TbxEnter.AppendText("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TbxEnter.AppendText("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TbxEnter.AppendText("9");
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TbxEnter.AppendText("0");
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            TbxEnter.AppendText(".");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

            TbxEnter.Clear();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            double temperature = Convert.ToDouble(TbxEnter.Text);
            if (RdbToF.Checked == true)
            {
                LblAns.Text = (9 / 5 * temperature + 32).ToString();
            }
            else if (RdbToC.Checked == true)
            {
                LblAns.Text = ((temperature - 32) * 5 / 9).ToString();
            }
        }
    }
}
