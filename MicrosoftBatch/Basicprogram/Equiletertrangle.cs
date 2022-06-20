using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Basicprogram
{
    class Equiletertrangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length of side");
            float side = float.Parse(Console.ReadLine());
            double root = Math.Sqrt(3) / 4F;
            double area = root * side * side;
            Console.WriteLine("area of equilateral triangle is :"+area);
            
        }
    }
}
