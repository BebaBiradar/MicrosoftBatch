using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Basicprogram
{
    class EWvenoddnumber
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a number:");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
