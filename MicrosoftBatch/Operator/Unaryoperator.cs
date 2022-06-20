using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Operator
{
    class Unaryoperator
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine(x++);//x=x+1;
            Console.WriteLine(++x);
            Console.WriteLine(x--);
            Console.WriteLine(--x);
        }
    }

    class Example
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 2;

            int x = ++b + a++ + b;
            Console.WriteLine(x + "" + a+""+b);//8,3,3
            x = a++ + --b - a;
            Console.WriteLine(x+""+a+""+b);//7,4,2//4,3,1
            x = --a - b-- - a;
            Console.WriteLine(x + "" + a + "" + b);//

        }
    }

    class Uservalue
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("enter the number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("x="+x);

        }

    }

    class Str
    {
        static void Main(string[] args)
        {
            string city;
            Console.WriteLine("enter valure");
            city = Console.ReadLine();
            Console.WriteLine(city);
        }
    }
}
