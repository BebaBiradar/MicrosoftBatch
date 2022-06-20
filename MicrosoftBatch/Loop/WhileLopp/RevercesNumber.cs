using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop.WhileLopp
{
    class RevercesNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eneter the number");
            int num = int.Parse(Console.ReadLine());
              
                int reverse = 0;
            while(num>0)
            {
                int r = num % 10;
                reverse = reverse * 10 + r;
                num = num / 10;
            }
            Console.WriteLine("revers is"+reverse);
        }
    }
}
