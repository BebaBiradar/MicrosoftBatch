using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Operator.Tarnary_operator
{
    class ExampleEvenodd
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the number :");
            n = int.Parse(Console.ReadLine());
            string st = (n % 2 == 0) ? "even" : "odd";
            Console.WriteLine(n + "is" + st);
            Console.ReadLine();
        }
    }

    class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eneter the number");
            int num = int.Parse(Console.ReadLine());
            string ans=num>0? "positive":num < 0? "negative" :"zero";
            Console.WriteLine(" "+ans);
           
        }
    }
}
