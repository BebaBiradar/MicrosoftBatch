using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Controlstatement
{
    class Divisibleny5and11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eneter any number:");
            int num = int.Parse(Console.ReadLine());
            if((num%5==0) && (num%11==0))
            {
                Console.WriteLine("the given number is divisible by 5 and 11:");
            }
            else
            {
                Console.WriteLine("the given number is not divisible by 5 and 11:");
            }
        }
    }
}
