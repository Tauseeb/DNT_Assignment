using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Assignment
{
    internal class FibonacciSeries
    {
        public static void Main()
        {
            int num, i, f1, f2, f3;
            f1 = 0; f2 = 1;
            Console.WriteLine("Please Enter the number to find fibonacci series..");
            num=Convert.ToInt32(Console.ReadLine());
            Console.Write(f1 + " " + f2);
            for (i = 1; i <= num; i++)
            {
                f3 = f1 + f2;
                Console.Write(" "+f3);
                f1 = f2;
                f2 = f3;
            }

        }
    }
}
