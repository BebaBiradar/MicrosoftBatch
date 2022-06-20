using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.ArrayDemo
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            //int[] a = { 4, 5, 6, 2, 8, 3, 9, 7 };
            int[] a = new int[5];
            Console.WriteLine("enter array element");
            for (int i = 0; i < a.Length; i++)
            {
                int n = a[i];
                bool isPrime = true;
                for (int j = 2; j < n; j++)
                {
                    if (n % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    Console.WriteLine(a[i]);
                }

            }
                
        }
    }
}
