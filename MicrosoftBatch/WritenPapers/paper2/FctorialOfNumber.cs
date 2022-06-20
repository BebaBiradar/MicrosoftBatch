using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test2
{
    class FctorialOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enetr the number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
                
        }
    }


    class Primenumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = 0;
            for(int i=2;i<num;i++)
            {
                if(num%i==0)
                {
                    temp++;
                }
            }
            if(temp == 0)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
