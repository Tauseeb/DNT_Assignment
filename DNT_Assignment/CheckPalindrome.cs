using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Assignment
{
    internal class CheckPalindrome
    {
        public static void Main()
        {
            int num, rem, sum=0, palin;
            Console.WriteLine("Enter the number to check Number is palindrome or not..");
            num=Convert .ToInt32(Console.ReadLine());
            palin = num;
            while (num!=0)
            {
                rem = num % 10;
                sum = sum * 10 + rem;
                num = num / 10;
            }
            if (palin == sum)
            {
                Console.WriteLine("Number is palindrome "+sum);
            }
            else
            {
                Console.WriteLine("Number is not palindrome "+sum);
            }
            Console.ReadLine();

        }
    }
}
