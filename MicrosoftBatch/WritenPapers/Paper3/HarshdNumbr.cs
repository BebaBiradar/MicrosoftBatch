using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.WritenPapers.Paper3
{
    class HarshdNumbr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int  sum = 0, temp = num, x;
            while(num>0)
            {
                x = num % 10;
                sum = sum + x;
                num=num / 10;
            }
            if (temp % sum == 0)
            {
                Console.WriteLine("number is Harshdnumber");
            }
            else
            {
                Console.WriteLine("number not harshad number");
            }
          
        }
    }
}
