using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.ArrayDemo
{
    class MaxMini
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 7, 3, 1, 8, 2 };
            int max = a[0];
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if(a[i]<min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Max=" + max);
            Console.WriteLine("Min=" + min);
        }
    }


    class MaMI
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 99, 95, 96, 98, 89 };
            int i, max, min;
           int n= 5;
            max = arr[0];
            min = arr[0];
            for(i=1;i<n;i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];

                }
                if(arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("maximum element:"+max);
            Console.WriteLine("minium element:"+min);
        }
    }
}
