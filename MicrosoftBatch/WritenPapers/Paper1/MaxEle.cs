using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.WritenPapers.Paper1
{
    class MaxEle
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for(int i=0;i<5;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int max = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]>max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
