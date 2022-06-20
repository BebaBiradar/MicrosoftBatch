using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.ArrayDemo
{
    class OddElement
    {
        static void Main(string[] args)
        {

            int[] arr = new[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("elementof given array present on odd position:");
            for (int i = 0; i < arr.Length; i = i + 2)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
