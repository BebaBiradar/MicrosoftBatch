using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.WritenPapers.Paper4
{
    class PerfectSq
    {
        //by using standard method
        static void Main(string[] args)
        {
            int[] arr = { 23, 43, 25, 49, 12, 9, 78, 66, 39, 0 };
            int per = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                float d = (float)Math.Sqrt(arr[i]);
                if(d%1==0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
    //by using for loop
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




    //1)  create a Array of integer and count the number of even  and odd elements from array.
    class oddEvenElement
    {
        static void Main(string[] args)
        {
            int size, oddsum = 0, evensum = 0, oddcount = 0, evencount = 0;
            Console.WriteLine("eneter the size of the element:");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("eneter array values:");
            for(int i=0;i<size;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<size;i++)
            {
                if(arr[i]%2==0)
                {
                    evensum += arr[i];
                    evencount++;
                }
                else
                {
                    oddsum += arr[i];
                    oddcount++;
                }
            }
            Console.WriteLine("even average:"+evensum/evencount+"Odd everage:"+oddsum/oddcount);
        }



        class EOD
        {
            static void Main(string[] args)
            {
                int[] a = { 4, 1, 7, 6, 3, 14 };
                Console.WriteLine("array length"+a.Length);
                Console.WriteLine("..............");
                int countEven = 0, Oddcount = 0;
                for(int i=0;i<a.Length;i++)
                {
                    if(a[i]%2==0)
                    {
                        countEven++;
                    }
                    else
                    {
                        Oddcount++;
                    }
                }
                Console.WriteLine("even element"+a,"odd element"+a);
            }
        }
        
    }



    /*6) Write a  program to separate zeros from non-zeros in an integer array?
    Input Array : [12, 0, 7, 0, 8, 0, 3]
    Input Array After moving zeros to end :
    [12, 7, 8, 3, 0, 0, 0]*/


    class SeparateZeroNonZero
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 0, 7, 0, 8, 0, 3 };
            for(int i=0;i<arr.Length;i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("after saparate zero or non zero:");
            Console.WriteLine(string.Join(" ",arr));
        }
    }


    //12.) WAP to replace all the 0’s with 1’s in your array.Your array is [26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34]

    class ReplaceZeroOnece
    {
        static void Main(string[] args)
        {
            int[] arr = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]==0)
                {
                    arr[i] = 1;
                }
            }
            Console.WriteLine(string.Join(" ",arr));
        }
    }
        


   /* 3) Write a program to find Minimum frequency char from an Array
   e.g char arr[] = {‘a’,’b’,’b’,’c’,’c’,’b’};*/

    class MinimumCharFre
    {
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'b', 'b', 'c', 'c', 'd' };
            char min = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("minimum aray element:"+min);

        }
    }


    /*13) Write a  program that prints the numbers
   from 1 to 50. But for multiples of three print “buzz” instead of the
   number and for the multiples of five print “fizz”. For numbers which
   are multiples of both three and five print “ buzzfizz “. After program
   looping is completed print how many times buzz was printed, fizz
   was printed and buzzfizz was printed.*/

    class Buzz
    {
        static void Main(string[] args)
        {
            int buzz = 0, fizz = 0, buzzfizz = 0;
            for(int i=1;i<=50;i++)
            {
                if(i%10==0||i%7==0)
                {
                    if(i%3==0)
                    {
                        buzz++;
                        //  WriteLine("buzz");
                    }
                    if(i%5==0)
                    {
                        fizz++;
                        //Console.WriteLine("fize");
                    }
                }
            }
        }
    }
}
