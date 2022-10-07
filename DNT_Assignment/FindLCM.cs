using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Assignment
{
    internal class FindLCM
    {
        public static void Main()
        {
            int i;
            Console.WriteLine("Please Enter First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= firstNumber * secondNumber; i++)
            {
                if (i % firstNumber == 0 && i % secondNumber == 0)
                {
                    break;
                }
            }
            Console.WriteLine("LCM is: " + i);
        }
    }
}
