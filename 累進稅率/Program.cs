using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 累進稅率
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 540000;
            decimal b = 1210000;
            decimal c = 2420000;
            decimal d = 4530000;
            decimal e = 10310000;
            decimal[] tax = new decimal[]{ a * 0.07m, b * 0.08m, c * 0.1m, d * 0.1m, e * 0.1m };
            decimal x = 0;
            

            Console.WriteLine("請輸入年收入 :");
            decimal income =decimal.Parse(Console.ReadLine());

            if (0 < income && income <= a)
            {
                decimal money1 = 0;
                money1 = a * 0.05m - x;
                Console.WriteLine(money1);
            }
            else if (income > a && income <= b)
            {
                decimal money2 = 0;
                x = tax[0];
                money2 = (income * 0.12m) - x;
                Console.WriteLine(money2);
            }
            else if (income > b && income <= c)
            {
                decimal money3 = 0;
                x = tax[0] + tax[1];
                money3 = (income * 0.2m) - x;
                
            }
            else if (income > c && income <= d)
            {
                decimal money4 = 0;
                x = tax[2];
                money4 = (income * 0.3m) - x;
                
            }
            else if (income > d && income <= e)
            {
                decimal money5 = 0;
                x = tax[3];
                money5 = (income * 0.4m) - x;
                
            }
            else if (income > e)
            {
                decimal money6 = 0;
                x = tax[4];
                money6 = (income * 0.5m) - x;
                
            }
            

        }
    }
}
