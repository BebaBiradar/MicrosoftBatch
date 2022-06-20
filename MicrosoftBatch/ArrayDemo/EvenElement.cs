using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.ArrayDemo
{
    class EvenElement
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("elementof given array present on even position:");
            for(int i=0;i<arr.Length;i=i+1)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
