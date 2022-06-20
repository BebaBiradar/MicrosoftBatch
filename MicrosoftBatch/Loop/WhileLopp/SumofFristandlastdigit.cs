using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop.WhileLopp
{
    class SumofFristandlastdigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eneter the number");
            int num = int.Parse(Console.ReadLine());
            int rem = int.Parse(Console.ReadLine());

            while (num > 10)
            {
                rem = num % 10;
                num /= 10;//num=num/10;
            }
               
            Console.WriteLine("the sum of frist and last digite is"+(rem+num));

        }

    }
}
