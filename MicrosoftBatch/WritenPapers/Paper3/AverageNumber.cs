using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.WritenPapers.Paper3
{
    class AverageNumber
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            float sum =0;
            int x;
             float count = 0;
            while(n>0)
            {
                x = n % 10;
                sum = sum + x;
                n = n /10;
                count++;
            }
            float avg = sum / count;
            Console.WriteLine(avg);

        }
       
    }


    class DigitSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int x;
            int count = 0;
            while (n > 0)
            {
                x = n % 10;
                sum = sum + x;
                n = n / 10;
                count++;
            }
            int avg = sum / count;
            Console.WriteLine(avg);
        }
    }
}
