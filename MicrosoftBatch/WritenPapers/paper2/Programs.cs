using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Test2
{
    class Programs
    {
        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);
        }
    }


    class Program1
    {
        static void Main(string[] args)
        {
            int i = 1,k= 1;
            while(i++<=5)
            {
                k *= i;
            }
            Console.WriteLine("k=" + k + "i=" + i);
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }
        }
    }

   
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number to check number is TrimorphicNumber or not ");
            int x = int.Parse(Console.ReadLine());

            int cube = x * x * x;
            Console.WriteLine("cube of" + x + "is:" + cube);
            int c = cube % 10;
            if (x == c)
            {
                Console.WriteLine(x + "number is TrimorphicNumber");
            }
            else
            {
                Console.WriteLine(x + "number is not TrimorphicNumber");
            }
        }
    }

    class Program5
    {
        static void Main(string[] args)
        {

            int n, s = 0, p = 1, d;
            Console.WriteLine("enter any  number");
            n = int.Parse(Console.ReadLine());
            for (; n > 0;)
            {
                d = n % 10;
                s = s + d;
                p = p * d;
                n = n / 10;
            }
            Console.WriteLine("sum of digite:" + s);
            Console.WriteLine("product of digite:" + p);
            if (s == p)
            {
                Console.WriteLine("Number is Spy");
            }
            else
            {
                Console.WriteLine("number is not  spy");
            }
        }
    }

    class Program6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for(int i=n;i>=0;i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j.ToString());
                Console.WriteLine();
            }
        }
    }


    class Program7
    {
        static void Main(string[] args)
        {
             int x, y, z;
            for (x =5; x >= 1; x--)
            {
                for (y =5; y > x; y--)
                {
                    Console.Write(" ");
                }
                for (z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }



    class Program8
    {
        static void Main(string[] args)
        {
            //find sum of factorial 1!2!3!4!
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                int fact = 1;
                for (int j = 1; j <= i; j++)
                {
                    fact = fact * j;
                }
                sum = sum + fact;
            }
            Console.WriteLine(sum);
        }
    }
}
