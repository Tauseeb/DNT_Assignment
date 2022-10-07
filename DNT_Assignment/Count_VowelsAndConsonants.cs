using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Assignment
{
    internal class Count_VowelsAndConsonants
    {
        public static void Main()
        {
            string sentance;
            int vowels, consonants, len, i;
            Console.WriteLine("Please Enter The Sentance For Count How many Numbers Of  Vowels And Consonants...");
            Console.WriteLine();
            sentance = Console.ReadLine();
            vowels= 0;  
            consonants= 0;
            len = sentance.Length;
            for (i = 0; i < len; i++)
            {
                if (sentance[i]=='a' || sentance[i]=='e' || sentance[i]=='i' || sentance[i]=='o' || sentance[i]=='u' ||
                     sentance[i] == 'A' || sentance[i] == 'E' || sentance[i] == 'I' || sentance[i] == 'O' || sentance[i] == 'U')
                {
                    vowels++;
                }
                else if(sentance[i]>='a' && sentance[i]<='z' || sentance[i] >= 'A' && sentance[i] <= 'Z')
                {
                    consonants++;
                }
            }
            Console.WriteLine("Numbers of vowels: "+vowels);
            Console.WriteLine("Numbers of consonants: "+consonants);

            Console.ReadLine();
        }
    }
}
