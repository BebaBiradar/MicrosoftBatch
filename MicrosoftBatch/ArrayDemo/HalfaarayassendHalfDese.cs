using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.ArrayDemo
{
    //create interger type of aaray an sort half array in descending array and remaining half array in asssending order
    class HalfaarayassendHalfDese
    {
        static void printOrder(int[]arr,int n)
        {
            //sorting the array
            Array.Sort(arr);
            //printing frist half in ascending order
            for(int i=0;i<n/2;i++)
                Console.WriteLine(arr[i]+" ");
            //printing frist half in ascending order
            for(int j=n-1;j>=n/2;j--)
                Console.WriteLine(arr[j]+" ");
        }
        //drived code
        public static void Main()
        {
            int[] arr = { 5, 4, 6, 2, 1, 3, 8, 9, 7 };
            int n = arr.Length;
            printOrder(arr, n);
        }
    }


    class SortingAscDe
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("enter array element:");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the original array is ");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            for(int i=0;i<arr.Length/2;i++)
            {
                for(int j=i+1;j<arr.Length/2;j++)
                {
                    if(arr[j]>arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.Write("Sorted Array is");
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
