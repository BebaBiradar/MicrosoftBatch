using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop.WhileLopp
{
    class Spy
    {
        static void Main(string[] args)
        {
            int n, s = 0, p = 1, d;
            Console.WriteLine("enter any  number");
            n = int.Parse(Console.ReadLine());
            for  (; n > 0; )
            {
                d = n % 10;
                s = s + d;
                p = p * d;
                n = n / 10;
            }
            Console.WriteLine("sum of digite:" + s);
            Console.WriteLine("product of digite:"+p);
            if(s==p)
            {
                Console.WriteLine("Number is Spy");
            }
            else
            {
                Console.WriteLine("number is not  spy");
            }
        }
    }
}
