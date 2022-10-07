using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Assignment
{
    internal class FindGCD
    {
        public static void Main()
        {

            Console.WriteLine("Enter First Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            while (num != num1)
            {
                if (num > num1)
                {
                    num = num - num1;
                }
                else
                {
                    num1 = num1 - num;
                }
            }
            Console.WriteLine("G.C.D of: " + num);
            Console.ReadLine();
        }
    }
}
