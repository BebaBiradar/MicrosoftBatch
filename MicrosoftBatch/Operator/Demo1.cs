using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Operator
{


    class Demo0
    {
        static void Main(string[] args)
        {
            Console.WriteLine(6+7-2*8/2);
            Console.WriteLine(5*2/2-7/5);
            Console.WriteLine((5+6/2)-2*5);
            Console.WriteLine(51%9-2*5);
            Console.WriteLine(72/8*2-(44-2/2));
        }
    }


    class Demo1
    {
        //Arithmatic operator
        static void Main(string[] args)
        {
            int num1, num2, addition, sub, multiplication, divison;
            num1 = 5;
            num2 = 19;
            //+,-,*,/,%---->a
            addition = num1 + num2;
            Console.WriteLine("sum of 2 number" + addition);

            sub = num1 - num2;
            Console.WriteLine("sub of 2 number" + sub);

            multiplication = num1 * num2;
            Console.WriteLine("multiplication of 2 number" + multiplication);

            divison = num1 / num2;
            Console.WriteLine("divison of 2 number" + divison);
        }
    }


    class Demo2
    {
        //Assignment operator +=,*=,/=,%=
        static void Main(string[] args)
        {
            int x = 10;
            x += 2;//x=x+2;
            Console.WriteLine(x);
            x -= 3;
            Console.WriteLine(x);
        }
    }

    class Demo3
    {
        //logical operator &&,||,!
        static void Main(string[] args)
        {
            int a = 2; int b = 7;int c = 6;
            Console.WriteLine((a > b) || (b > c)) ;
            Console.WriteLine((b>a)&&(b>c));
        }
    }

    class Demo4
    {
        //Relational operator <,>,<=,>=,!=,==
        static void Main(string[] args)
        {
            int a = 9;
            int b = 7;
            Console.WriteLine(a>b);
            Console.WriteLine(a < b);
            Console.WriteLine(a == b);
            Console.WriteLine(a!=b);
               
                
                

        }

    }
}
