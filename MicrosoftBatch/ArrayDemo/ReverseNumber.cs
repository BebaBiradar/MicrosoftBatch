using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.ArrayDemo
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 6, 2, 8 };
            foreach(int p in a)
            {
                Console.WriteLine(p+" ");
            }
            Console.WriteLine("/////////////");
            for(int i=a.Length-1;i>=0;i--)
            {
                Console.WriteLine(a[i]+" ");
            }

        }
    }
}
