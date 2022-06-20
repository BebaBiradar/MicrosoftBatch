using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop.NestedLoop
{
    class Disarium
    {
        static void Main(string[] args)
        {
            /* for (int num = 1; num <= 5; num++) 
             {
                 for(int i=1;i<=10;i++)
                 {
                     Console.WriteLine(num * i + "");
                 }
                 Console.WriteLine();
             }*/

            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int count = 0;
            while(num>0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine(count);
            num = temp;
            int sum = 0;
            while(num>0)
            {
                int r = num % 10;
                int power = 1;
                for(int i=1;i<=count;i++)
                {
                    power = power * r;
                }
                sum = sum + power;
                count--;
                num = num / 10;

            }
            num = temp;
            if(num==sum)
            {
                Console.WriteLine("disarium");
            }
            else
            {
                Console.WriteLine("not disarium");
            }
            
        }
    } 
}
