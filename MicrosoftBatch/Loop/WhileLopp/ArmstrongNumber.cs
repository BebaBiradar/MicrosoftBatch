using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop.WhileLopp
{
    class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = 0, sum = 0;
            temp = num;
            while(temp>0)
            {
                int rem = temp % 10;
                sum = sum + (rem * rem * rem);
                temp = temp / 10;
            }
            if(sum==num)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("not ArmstrongNumber");
            }

        }
    }
}
