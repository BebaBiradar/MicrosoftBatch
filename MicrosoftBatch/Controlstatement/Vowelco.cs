using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Controlstatement
{
    class Vowelco
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter char");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 'a')
            {
                Console.WriteLine("vowel");
            }
            else if (ch == 'e')
            {
                Console.WriteLine("vowel");
            }
            else if (ch == 'i')
            {
                Console.WriteLine("vowel");
            }
            else if (ch == 'o')
            {
                Console.WriteLine("vowel");
            }
            else if (ch == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }
        }
    }
}

