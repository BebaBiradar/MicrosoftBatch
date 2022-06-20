using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.ArrayDemo
{
    class SumofPrimeNumber
    {
        static void Main(string[] args)
        {
            int i, j, p, s = 0;
            int[] arr = new int[5];
            Console.WriteLine("eneter array element:");
            for(i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(i=0;i<arr.Length;i++)
            {
                j = 2;
                p = 1;
                while (j < arr[i])
                {
                    if(arr[i]%j==0)
                    {
                        p = 0;
                        break;
                    }
                    j++;
                }
                if(p==1)
                {
                    s = s + arr[i];
                }


            }
            Console.WriteLine("sum of prime number:"+s);
             
        }
    }
}
