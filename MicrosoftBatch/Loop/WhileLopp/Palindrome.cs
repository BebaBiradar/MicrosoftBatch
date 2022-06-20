using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop.WhileLopp
{
    class Palindrome
    {
        static void Main(string[] args)
        {
           Console.WriteLine("eneter the number");
            int num = int.Parse(Console.ReadLine());
            int reverse = 0, temp;
            temp = num;
            while(temp>0)
            {
                int rem = temp % 10;
                reverse = (reverse * 10) + rem;
                temp = temp / 10;
            }
            if(num==reverse)
            {
                Console.WriteLine("Number is palidrome");
            }
            else
            {
                Console.WriteLine("n umber is not palidrome");
            }
        }
    }
}
