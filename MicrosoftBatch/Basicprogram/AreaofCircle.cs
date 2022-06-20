using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Basicprogram
{
    class AreaofCircle
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            Console.WriteLine("Enter the radius of circle:");
            double radius = double.Parse(Console.ReadLine());
            double area = double.Parse(Console.ReadLine());
            area = pi * radius * radius;
            {
                Console.WriteLine(area);
            }
        }
    }

    class Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value to calculate the area of triangle");
            Console.WriteLine("enter the value of three sides of triangle");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float s = (a + b + c) / 2F;
            double result = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("area of triangle="+result);
        }
    }

    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter value of lenght and breadth");
            float len = float.Parse(Console.ReadLine());

            float brth = float.Parse(Console.ReadLine());
            double cl = len * brth;
            Console.WriteLine("area or rectangle="+cl);
        }
    }
}
