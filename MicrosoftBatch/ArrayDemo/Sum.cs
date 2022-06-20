using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.ArrayDemo
{
    class Sum
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 6, 2, 8 };
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine(sum);
            
        }
    }
}
