using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Assignment
{
    public class CheckPrime
    {
        public static void Main()
        {
            int num, i, count = 0;
            Console.WriteLine("Enter the number to check number is prime or not..");
            num = Convert.ToInt32(Console.ReadLine());
           
                for(i= 1;i<=num;i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                if(count== 2)
                {
                    
                Console.WriteLine("Number is prime.");
                }
                else
                {
                    Console.WriteLine("Number is not prime..");
                }
                 
            
            Console.ReadLine();
        }

    }
}
