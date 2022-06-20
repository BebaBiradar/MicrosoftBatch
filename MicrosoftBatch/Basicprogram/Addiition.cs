using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Basicprogram
{
    class Addiition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two number");
            int a= int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine(sum);


        }
    }
}
