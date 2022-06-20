using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter frist number:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enetr second");
            int n2 = int.Parse(Console.ReadLine());

            int avg =( n1 + n2) / 2;
            Console.WriteLine(" avg of :"+avg);
               
           
            
        }
    }

    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter digit:");
            int num = int.Parse(Console.ReadLine());
            int avg;
            avg = num / 10;
            Console.WriteLine("the avg of digit:"+avg);
        }
    }
}

