using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Controlstatement
{
    class Leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a year:");
            int year = int.Parse(Console.ReadLine());
            if ((year % 400) == 0)
            {
                Console.WriteLine("leap year");
            }

            else if ((year % 100) == 0)
            {

                Console.WriteLine("not leap year");
            }
            else if ((year % 4) == 0)
            {

                Console.WriteLine("leap year");
            }
            else
            {

                Console.WriteLine("not leap year");
            }
        }
    }
}
