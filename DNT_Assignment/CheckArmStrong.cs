using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Assignment
{
    internal class CheckArmStrong
    {
        
        public static void Main()
        {
            int num, rev, rem = 0, arm;

            Console.WriteLine("Enter Number TO Check Number is ArmStrong or Not..");
            num = Convert.ToInt32(Console.ReadLine());
            arm = num;
            while (num != 0)
            {
                rev = num % 10;
                rem = rev * rev * rev + rem;
                num = num / 10;
            }
            if (arm == rem)
            {
                Console.WriteLine("Number is ArmStrong");
            }
            else
            {
                Console.WriteLine("Number is Not ArmStrong.");
            }

            Console.ReadLine();
        }
    }
}
