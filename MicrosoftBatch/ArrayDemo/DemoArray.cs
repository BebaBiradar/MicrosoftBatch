using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.ArrayDemo
{
    class DemoArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 5, 23, 6 };
            int[] a = new int[4];
             /*a[0]=5;
            a[1] = 56;
            a[2] = 34;
            a[3] = 12;*/
            Console.WriteLine("enter array value");
            for(int i=0;i<a.Length;i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                a[i] = x;
            }
            Console.WriteLine("//////////////////////////");
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("/////////////////////////////");
            //1
            foreach(int x in a)
            {
                Console.WriteLine(x);
            }
            /*Console.WriteLine("////////////////////////////////");
            a.ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("//////////////////");
            Console.WriteLine(string.Join(" ",a));*/

           
        }


    }
}
