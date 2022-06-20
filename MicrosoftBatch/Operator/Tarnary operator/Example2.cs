using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Operator.Tarnary_operator
{
    class Example2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eneter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("eneter 2 nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enetr 3 rd number");
            int num3 = int.Parse(Console.ReadLine());

            string st = num1 > num2 ? (num1 > num3) ? "num1 is grater" : "num3 is grater" : num2 > num3 ? "num2 is grater" : "num3 is grater";
            Console.WriteLine(st);
        }
    }

    class Example3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1 st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2 nd numner");
            int num2 = int.Parse(Console.ReadLine());
            /* int result = (num1 > num2) ? num1 : num2;
             Console.WriteLine("max number is="+result);*/

            /* String result = num1 > num2 ? "num1 is gr" : "num2 is gr";
             Console.WriteLine(result);*/

            Console.WriteLine(num1>num2?"num1 is gr":"num2 is gr");
        }
    }
}
