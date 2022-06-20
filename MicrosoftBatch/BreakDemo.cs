using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch
{
    class BreakDemo
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                if(i==3)
                {
                    break;

                }
                Console.WriteLine(i);
            }
        }
    }


    class Continue
    {
        static void Main(string[] args)
        {
         for(int i=1;i<=5;i++)
            {
                if(i==3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }

    class Example
    {
        static void Main(string[] args)
        {
            int magicnumber = 45;
            for(; ; )
            {
                Console.WriteLine("enter the number");
                int num = int.Parse(Console.ReadLine());
                if(num<magicnumber)
                {
                    Console.WriteLine("number is less try again");
                    continue;
                }
                else if(num>magicnumber)
                {
                    Console.WriteLine("number grater try again");
                    continue;
                }
                else
                {
                    Console.WriteLine("magicnumber is correct");
                    break;
                }
            }
        }
    }
}
