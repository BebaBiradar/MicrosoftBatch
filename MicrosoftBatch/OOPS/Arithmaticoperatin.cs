using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS
{
    class Arithmaticoperatin
    {
        void calculate(int a,int b,int c)
        {
            Console.WriteLine("addition is:" + (a + b + c));

        }
        void calculate(int a , float b)
        {
            Console.WriteLine("substraction is:" + (a - b));
        }
        void calculate(float a,float b)
        {
            Console.WriteLine("multiplication is:" + (a * b));
        }
        void calculate(double a,float b)
        {
            Console.WriteLine("divison:" + (a / b));
        }
        static void Main(string[] args)
        {
            Arithmaticoperatin a = new Arithmaticoperatin();
            a.calculate(10, 10);
            a.calculate(2, 3.3f);
            a.calculate(2.2f, 3.3f);
            a.calculate(20.4, 3.3f);


        }
    }
}
