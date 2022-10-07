using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Assignment
{
    internal class FindFactorial
    {
        public static void Main()
        {
            int num, fact, i;
            Console.WriteLine("Enter a number to find factorial");
            num=Convert .ToInt32(Console.ReadLine());
            fact = 1;
            for(i=1;i<=num;i++)
            {
                fact=fact*i;
            }
            Console.WriteLine("Factorial is "+fact);
            Console.ReadLine();
        }
    }
}
