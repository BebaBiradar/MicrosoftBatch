﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.ArrayDemo
{
    class MaxElemenet
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 7, 3, 1, 8, 2 };
            int max = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]>max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Max="+max);
        }
    }
}
