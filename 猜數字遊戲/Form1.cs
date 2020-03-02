using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 猜數字遊戲
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ans;
        List<string> list = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            BtnRestart.Enabled = false;
            BtnCheck.Enabled = false;
            BtnAnswer.Enabled = false;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            BtnRestart.Enabled = true;
            Random ran = new Random();
            int i;

            while (list.Count < 4)
            {
                i = ran.Next(0, 10);
                if (list.Any((x) => x == i.ToString()) == false)
                {
                    list.Add(i.ToString());
                }
            }
            ans = list[0].ToString() + list[1].ToString() + list[2].ToString() + list[3].ToString();
            MessageBox.Show(ans);

        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ans);

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            string input = TbxGuess.Text;
            int b; int a = 0;

            var intersect = ans.Intersect(input);
            b = intersect.Count();

            foreach (var item in intersect)
            {
                if (input.IndexOf(item) == ans.IndexOf(item))
                {
                    a++;
                }
            }
            b = b - a;
            TbxHistory.Text += input + "  " + a + "A" + b + "B" + Environment.NewLine;
            if (a == 4 && b == 0)
            {
                MessageBox.Show("恭喜過關");
            }

        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {

            TbxHistory.Clear();
            TbxGuess.Clear();
        }
    }
}
