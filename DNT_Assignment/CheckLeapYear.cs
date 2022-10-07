using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Assignment
{
    internal class CheckLeapYear
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter A Year To Check Year is Leap or Not..");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year % 4 ==0 && (year % 100 !=0) || (year % 400 ==0))
            {
                Console.WriteLine("is a Leap Year. {0}",year);
            }
            else
            {
                Console.WriteLine("is not a Leap Year.. {0}",year);
            }
            Console.ReadLine();

        }
    }
}
