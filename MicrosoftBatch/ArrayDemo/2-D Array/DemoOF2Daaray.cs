using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.ArrayDemo._2_D_Array
{
    class DemoOF2Daaray
    {
        static void Main(string[] args)
        {
            /*int[,] a = { { 4,5,6},
                           {7,6,8 },
                           {5,6,7}};*/
            //int[,] a = new int[3, 3] { { 1, 2, 3 }, { 3, 4, 5 }, { 5, 7, 8 } };
            int[,] a = new int[2, 2];
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(".......................");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.Write(a[i,j]+" ");
                }
            }
            Console.WriteLine(".....................");
            for (int i = 0; i < a.GetUpperBound(0); i++)
            {
                for (int j = 0; j < a.GetUpperBound(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("////////////////////");
            foreach(int x in a)
            {
                Console.WriteLine(" "+x);
            }

        }
        
    }
}
