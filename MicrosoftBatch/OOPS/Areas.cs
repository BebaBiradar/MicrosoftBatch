using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS
{
    class Areas
    {
        public void Area(double radius)
        {
            double pi = 3.14;
            double result = 3.14 * pi * pi;
            Console.WriteLine("area of circle:"+result);
        }
        public void Area(int length,int breadth)
        {
            int result = length * length;
            Console.WriteLine("area of reactangle:"+result);
        }
        /*public void area(double baseof,double height)
        {
            double result = (baseof * height) / 2;
            Console.WriteLine("area of triangle:"+result);
        }*/
        public void area(int side)
        {
            int result = side * side;
            Console.WriteLine("area of square:"+result);
        }
        static void Main(string[] args)
        {
            Areas a = new Areas();
            a.Area(9.5);
            a.Area(10, 20);
           // a.Area(2.5, 7.99);
            a.Area(15);


        }

    }
}
