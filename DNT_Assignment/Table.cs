using System;

class Table
{
    public static void Main()
    {
        int num, i;
        Console.WriteLine("Enter the number");
        num = Convert.ToInt32(Console.ReadLine());
        for(i=1;i<=10;i++)
        {

            Console.WriteLine(num + "*" + i + "= "+ num * i);

        }
        Console.ReadLine();
    }
    
}