using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop.Dowhile
{
    class TrimorphicNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number to check number is TrimorphicNumber or not ");
            int x = int.Parse(Console.ReadLine());
            
            int cube = x * x * x;
            Console.WriteLine("cube of"+x+"is:"+cube);
            int c = cube % 10;
            if(x==c)
            {
                Console.WriteLine(x+ "number is TrimorphicNumber");
            }
            else
            {
                Console.WriteLine(x+ "number is not TrimorphicNumber");
            }
        }
    }
}
