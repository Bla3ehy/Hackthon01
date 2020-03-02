using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 生命靈數
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Searchdata()
        {
            int year = dateTimePicker1.Value.Year;
            DateTime a牡羊 = new DateTime(year, 3, 21);
            DateTime b牡羊 = new DateTime(year, 4, 19);
            DateTime a金牛 = new DateTime(year, 4, 20);
            DateTime b金牛 = new DateTime(year, 5, 20);
            DateTime a雙子 = new DateTime(year, 5, 21);
            DateTime b雙子 = new DateTime(year, 6, 21);
            DateTime a巨蟹 = new DateTime(year, 6, 22);
            DateTime b巨蟹 = new DateTime(year, 7, 22);
            DateTime a獅子 = new DateTime(year, 7, 23);
            DateTime b獅子 = new DateTime(year, 8, 22);
            DateTime a處女 = new DateTime(year, 8, 23);
            DateTime b處女 = new DateTime(year, 9, 22);
            DateTime a天秤 = new DateTime(year, 9, 23);
            DateTime b天秤 = new DateTime(year, 10, 23);
            DateTime a天蠍 = new DateTime(year, 10, 24);
            DateTime b天蠍 = new DateTime(year, 11, 22);
            DateTime a射手 = new DateTime(year, 11, 23);
            DateTime b射手 = new DateTime(year, 12, 21);
            DateTime a摩羯 = new DateTime(year, 12, 22);
            DateTime c摩羯 = new DateTime(year, 12, 31);
            DateTime b摩羯 = new DateTime(year, 1, 1);
            DateTime d摩羯 = new DateTime(year, 1, 19);
            DateTime a水瓶 = new DateTime(year, 1, 20);
            DateTime b水瓶 = new DateTime(year, 2, 18);
            DateTime a雙魚 = new DateTime(year, 2, 21);
            DateTime b雙魚 = new DateTime(year, 3, 20);

            var date = dateTimePicker1.Value.Date;

            if (a牡羊 <= date && date <= b牡羊)
            {
                return "牡羊座";
            }
            else if (a金牛 <= date && date <= b金牛)
            {
                return "金牛座";
            }
            else if (a雙子 <= date && date <= b雙子)
            {
                return "雙子座";
            }
            else if (a巨蟹 <= date && date <= b巨蟹)
            {
                return "巨蟹座";
            }
            else if (a獅子 <= date && date <= b獅子)
            {
                return "獅子座";
            }
            else if (a處女 <= date && date <= b處女)
            {
                return "處女座";
            }
            else if (a天秤 <= date && date <= b天秤)
            {
                return "天秤座";
            }
            else if (a天蠍 <= date && date <= b天蠍)
            {
                return "天蠍座";
            }
            else if (a射手 <= date && date <= b射手)
            {
                return "射手座";
            }
            else if (a摩羯 <= date && date <= c摩羯 || b摩羯 <= date && date <= d摩羯)
            {
                return "摩羯座";
            }
            else if (a水瓶 <= date && date <= b水瓶)
            {
                return "水瓶座";
            }
            else if (a雙魚 <= date && date <= b雙魚)
            {
                return "雙魚座";
            }

            return "";
        }

        private void lifeNumber()
        {
            int i = 0;
            int j = 0;
            var value = dateTimePicker1.Value.Year.ToString() + dateTimePicker1.Value.Month.ToString() + dateTimePicker1.Value.Day.ToString();
            foreach (var x in value)
            {
                i += int.Parse(x.ToString());
            }
            if (i > 9)
            {
                foreach (var item in i.ToString())
                {
                    j += int.Parse(item.ToString());
                }
            }

            label5.Text = j.ToString();

        }

        private void BtnAns_Click(object sender, EventArgs e)
        {
            string o;
            lifeNumber();
            o = Searchdata();
            label3.Text += o;

            switch (o)
            {
                case "牡羊座":
                    var z = Class1.CreateAries();
                    var y = z[int.Parse(label5.Text)];
                    label4.Text = y;
                    break;
                case "金牛座":
                    z = Class1.CreateTaurus();
                    y = z[int.Parse(label5.Text)];
                    label4.Text = y;
                    break;
                case "雙子座":
                    z = Class1.CreateGemini();
                    y = z[int.Parse(label5.Text)];
                    label4.Text = y;
                    break;
                case "巨蟹座":
                    z = Class1.CreateCancer();
                    y = z[int.Parse(label5.Text)];
                    label4.Text = y;
                    break;
                case "獅子座":
                    z = Class1.CreateLeo();
                    y = z[int.Parse(label5.Text)];
                    label4.Text = y;
                    break;
                case "處女座":
                    z = Class1.CreateVirgo();
                    y = z[int.Parse(label5.Text)];
                    label4.Text = y;
                    break;
                case "天秤座":
                    z = Class1.CreateLibra();
                    y = z[int.Parse(label5.Text)];
                    label4.Text = y;
                    break;
                case "天蠍座":
                    z = Class1.CreateScorpio();
                    y = z[int.Parse(label5.Text)];
                    label4.Text = y;
                    break;
                case "射手座":
                    z = Class1.CreateSagittarius();
                    y = z[int.Parse(label5.Text)];
                    label4.Text = y;
                    break;
                case "摩羯座":
                    z = Class1.CreateCapricorn();
                    y = z[int.Parse(label5.Text)];
                    label4.Text = y;
                    break;
                case "水瓶座":
                    z = Class1.CreateAquarius();
                    y = z[int.Parse(label5.Text)];
                    label4.Text = y;
                    break;
                default:
                    z = Class1.CreatePieces();
                    y = z[int.Parse(label5.Text)];
                    label4.Text = y;
                    break;
            }

        }
    }
}
