using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 質數問題
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 101; i <= 200; i++)
            {
                bool isFind = false;
                for (int y = 2; y < i; y++)
                {
                    if (i % y == 0)
                    {
                        isFind = true;
                    }
                }
                if (!isFind)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }

}


