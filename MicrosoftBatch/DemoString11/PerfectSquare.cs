using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.String
{
    class PerfectSquare
    {
        static void Main(string[] args)
        {
            int[] arr = { 23, 43, 25, 49, 12, 9, 78, 66, 39, 0 };
            Console.WriteLine("array element are:" + string.Join(" ", arr));
            Console.WriteLine("perfect square element from array are:");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0 && arr[i] / j == j)
                    {
                        Console.WriteLine(arr[i]);
                    }

                }
            }
        }
    }
}
