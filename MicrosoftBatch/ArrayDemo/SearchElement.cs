using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.ArrayDemo
{
    class SearchElement
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 4, 2, 9, 1 };
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine("enter number for search");
            int num = int.Parse(Console.ReadLine());
            bool isPresent = false;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==num)
                {
                    isPresent= true;
                    break;
                }
            }
            if(isPresent==true)
            {
                Console.WriteLine("present");
            }
            else
            {
                Console.WriteLine("not present");
            }
                

        }
    }
}
