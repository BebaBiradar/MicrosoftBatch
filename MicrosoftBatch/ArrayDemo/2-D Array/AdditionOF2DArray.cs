using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.ArrayDemo._2_D_Array
{
    class AdditionOF2DArray
    {
        static void Main(string[] args)
        {
            int[,] a = { { 5, 4, 3 }, { 7, 8, 1 }, { 9, 2, 3} };
            for(int i=0;i<a.GetLength(0);i++)
            {
             for(int j = 0;j< a.GetLength(1);j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("/////////////////////");

            int[,] b = { { 5, 4, 3 }, { 7, 8, 1 }, { 9, 2, 3 } };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("////////////////////////////////");

            int[,] c = new int[3, 3];
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<b.GetLength(1);j++)
                {
                    c[i, j] = a[i, j] + b[i , j];
                }
            }
            Console.WriteLine("  ");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<b.GetLength(1);j++)
                {
                    Console.Write(c[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
