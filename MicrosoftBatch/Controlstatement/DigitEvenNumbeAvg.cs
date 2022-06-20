using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Controlstatement
{
    class DigitEvenNumbeAvg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number:");
            int num = int.Parse(Console.ReadLine());
            int avg = 0;
            int sum = 0;
            int count = 0;
            while (num > 0)
            {
                int digit = num % 10;
             
                
                if (digit % 2 == 0)
                {
                    sum = sum + digit;
                    count++;

                }
                avg = sum / count;
                num = num / 10;
                Console.WriteLine("Average of even digits from the number::"+avg);
            }
        }
    }
}
