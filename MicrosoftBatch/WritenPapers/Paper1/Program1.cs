using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Testpepar1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length of side");
            float side = float.Parse(Console.ReadLine());
            double root = Math.Sqrt(3) / 4F;
            double area = root * side * side;
            Console.WriteLine("area of equilateral triangle is :" + area);
        }
    }



    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of all five subject:");
            Console.WriteLine("enter the marks of frist subject");
            float sub1 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks of second subject");
            float sub2 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks of third subject");
            float sub3 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks of fourth subject");
            float sub4 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks of fifth subject");
            float sub5 = float.Parse(Console.ReadLine());
            double total = (sub1 + sub2 + sub3 + sub4 + sub5) / 500;
            double marks = total * 100;
            Console.WriteLine("percentage of subject =" + marks);
        }
    }



    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a year:");
            int year = int.Parse(Console.ReadLine());
            if ((year % 400) == 0)
                Console.WriteLine("leap year");

            else if ((year % 100) == 0)
                Console.WriteLine("not leap year");
            else if ((year % 4) == 0)
                Console.WriteLine("leap year");
            else
                Console.WriteLine("not leap year");
        }
    }


   class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eneter any number:");
            int num = int.Parse(Console.ReadLine());
            if ((num % 5 == 0) && (num % 11 == 0))
            {
                Console.WriteLine("the given number is divisible by 5 and 11:");
            }
            else
            {
                Console.WriteLine("the given number is not divisible by 5 and 11:");
            }
        }
   }



    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a charecter:");
            char ch = char.Parse(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonent");
            }
        }  
    }


    class Program6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a charecter");
            char cr = char.Parse(Console.ReadLine());
            if ((cr >= 'a' && cr <= 'z') || (cr >= 'A' && cr <= 'Z'))
            {
                Console.WriteLine("this is a charecter");
            }
            else if (cr >= '0' && cr <= '9')
            {
                Console.WriteLine("this is digite");
            }
            else
            {
                Console.WriteLine("this is special symbole");
            }
        }
    }

    class Program7
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a number:");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }

    class Program8
    {
        static void Main(string[] args)
        {
            char Operator;
            float n1, n2, result = 0;
            Console.WriteLine("enter any operatore:");
            Operator = char.Parse(Console.ReadLine());
            Console.WriteLine("enter the values of operand n1 and n2:");
            n1 = float.Parse(Console.ReadLine());
            n2 = float.Parse(Console.ReadLine());

            switch (Operator)
            {
                case '+':
                    result = n1 + n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
                case '*':
                    result = n1 * n2;
                    break;
                case '/':
                    result = n1 / n2;
                    break;
                default:
                    break;

            }
            Console.WriteLine(n1 + "" + Operator + "" + n2 + ":" + result);
        }   
    }


    class program9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 3 number:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    max = n1;
                }
                else
                {
                    max = n3;
                }
            }
            else
            {
                if (n2 > n3)
                {
                    max = n2;
                }
                else
                {
                    max = n3;
                }

            }

            Console.WriteLine("max among all there numbers is:", max);
        }
    }

    class Program10
    {
        static void Main(string[] args)
        {
            int a = 5, b = 4, c = 3;
            Console.WriteLine(a++ + b * ++c);
            Console.WriteLine("a=" + a + "b=" + b + "c=" + c);
            Console.WriteLine(b * 5 / a + b++ + b);
            Console.WriteLine("a=" + a + "b=" + b + "c=" + c);
        }
    }
    
}

