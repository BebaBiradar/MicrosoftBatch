using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.ArrayDemo._2_D_Array
{
    /*5 4 3 3
      7 8 1 6
      9 2 3 4
      3 5 1 9*/


    class TwoDPatern
    {
        static void Main(string[] args)
        {
            int[,] a = { { 5, 4, 3, 3 }, { 7, 8, 1, 6 }, { 9, 2, 3, 4 }, { 3, 5, 1, 9 } };
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
        /* 5433
         7  6
         9  4
         3519*/
         
    class Patter1
    {
        static void Main(string[] args)
        {
            int[,] a = { { 5, 4, 3, 3 }, { 7, 8, 1, 6 }, { 9, 2, 3, 4 }, { 3, 5, 1, 9 } };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                  if(i==0 ||j==0||i==a.GetUpperBound(0)||j==a.GetUpperBound(1))
                    {
                        Console.Write(a[i,j]+"");
                    }
                  else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }   
        }
    }

     /*  ****
         *  *
         *  *
         **** */


    class Patter2
    {
        static void Main(string[] args)
        {
            char[,] ch = new char[4, 4];
            for(int i=0;i<=ch.GetUpperBound(0);i++)
            {
                for(int j=0;j<=ch.GetUpperBound(1);j++)
                {
                    if(i == 0 || j == 0 || i == ch.GetUpperBound(0)||j==ch.GetUpperBound(1))
                    {
                        ch[i, j] = '*';
                    }
                    else
                    {
                        ch[i, j] = ' ';
                    }
                }
            }
            for(int i=0;i<=ch.GetUpperBound(0);i++)
            {
                for(int j=0;j<=ch.GetUpperBound(1);j++)
                {
                    Console.Write(ch[i,j]);
                }
                Console.WriteLine();
            }

        }
    }


    class Patter3
    {
        static void Main(string[] args)
        {
            char[,] ch = new char[4, 4];
            for (int i = 0; i <= ch.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= ch.GetUpperBound(1); j++)
                {
                    if (j == 1 || j == 4 || i == j)
                    {
                        ch[i, j] = '*';
                    }
                    else
                    {
                        ch[i, j] = ' ';
                    }
                }
            }
            for (int i = 0; i <= ch.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= ch.GetUpperBound(1); j++)
                {
                    Console.Write(ch[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
