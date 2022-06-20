using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop.ForLoopp
{
    class Demo
    {
        static void Main(string[] args)
        {
            //for(intilization;condition;incre/dec)
            //{
            //logic
            //  }

            /* int i;
             for(i=1;i<=5;i++)
             {
                 Console.WriteLine(i);
             }*/


            /* for (int i = 1; i <= 5; i++)
            {
                 Console.WriteLine(i);
            }*/

            /*for(int i=1;i<=5;i--)
             {
                 Console.WriteLine(i);
             }*/

            /* for(int i=5;i>=1;i--)
             {
                 Console.WriteLine(i);
             }*/

            /* int i = 1;
             for(;i<=5;i++)
             {
                 Console.WriteLine(i) ;
             }*/

            /* for(int i=1; ; i++)
             {
                 Console.WriteLine("hi");
             }*/

            /* for(int i=1;i<=5;)
             {
                 Console.WriteLine(i);
             }*/

            /* for (int i = 1; i <= 5; i++) ;
             {
                 Console.WriteLine("hi");
             }*/

            /* for(int i=1;i<=5;i++)
             {
                 Console.WriteLine(i);
             }*/

            /* for(int i=10;i<=1;i--)
             {
                 Console.WriteLine(i);
             }*/
            for (; ; )
            {
                Console.WriteLine("hiii");
            }


        }
    }

    class Exaample2
    {
        //write a code to display number between 35 to 75
        static void Main(string[] args)
        {
            int i;
            for (i = 35; i <= 75; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Example3
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 35; i <= 125; i++)
            {
                Console.WriteLine(i);
            }
        }
    }


    class Example4
    {
        //write  a code to display number between 125 to 85
        static void Main(string[] args)
        {
            int i;
            for (i = 125; i >= 85; i--)
            {
                Console.WriteLine(i);
            }

        }
    }

    class Example5
    {
        //write a code to display odd numbers between 25 to 45
        static void Main(string[] args)
        {
            int i;
            for (i = 25; i <= 45; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }


    class Example6
    {
        //write a code to findout factor sum of given number
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 25; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }


    class Example7
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.WriteLine("entert number");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of factors =" + sum);
        }

    }

    class Example8
    {
        //write the code to findout power  of given number take the base and exponant from user than clculate power
        static void Main(string[] args)
        {
            Console.WriteLine("enter the base:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the exponent:");
            int e = int.Parse(Console.ReadLine());
            int power = b;
            for (int i = 1; i < e; i++)
            {
                power *= b;
            }
            Console.WriteLine(power);
        }
    }

    class Example9
    {
        //write a code to display table of given number
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number for table");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + "*" + i + "=" + (i * n));
            }
        }
    }


    class Sum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }


    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                //fact = fact * i;
                fact *= i;
            }
            Console.WriteLine(fact);
        }

    }
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
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
