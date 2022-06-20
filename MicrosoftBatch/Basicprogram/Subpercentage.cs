using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Basicprogram
{
    class Subpercentage
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
            Console.WriteLine("percentage of subject ="+marks);



        }
    }
}
