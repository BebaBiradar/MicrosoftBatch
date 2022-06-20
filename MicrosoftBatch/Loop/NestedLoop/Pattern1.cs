using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop.NestedLoop
{
    /*1
      2
      3
      4  */
    class Pattern1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++) ;
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

        }
    }
    /* 1

        1
        2

        1
        2
        3

        1
        2
        3
        4  */
    class Pattern2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine(j + " ");
                }
                Console.WriteLine();
            }
        }
    }


    /*  1

       2
       2

       3
       3
       3

       4
       4
       4
       4  */

    class Pattern3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine(i + "");
                }
                Console.WriteLine();
            }
        }

    }

    /*

      *
      *
       
      *
      *
      *
      
      *
      *
      *
      *  */


    class Pattern4
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)

            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
    }
    //*****************************
    class Pattern5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                    Console.WriteLine("*");
            }
            Console.WriteLine();
        }
    }

    //122333444455555
    class Pattern6
    {
        static void Main(string[] args)
        {
            int c = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(c);
                c++;
            }
            Console.WriteLine();

        }
    }

    /*1234
      123
      12
      1*/
    class Pattern7
    {
        static void Main(string[] args)
        {


            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
        /*  4321
            423
            43
            4  */
        class Pattern8
        {
            static void Main(string[] args)
            {
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 4; j >= i; j--)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }

            }
        }

    
    /* *****
       ****
       ***
       **
       *  */
    class Pattern9
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    /*   *****
         *****
         *****
         *****
         *****  */

    class Pattern10
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine();
        }

    }

    /*   *****
         *
         *
         *****   */


    class Pattern11
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)

                {
                    if (i == 1 || i == 5 || j == 1 || j == 5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                    }
                }
                Console.WriteLine();

            }

        }
    }
    /*  *******
         *****
          ***
           *    */


    class Pattern12
    {
        static void Main(string[] args)
        {
            int x, y, z;
            for (x = 4; x >= 1; x--)
            {
                for (y = 4; y > x; y--)
                {
                    Console.Write(" ");
                }
                for (z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }


 
         //SquareProgram


    class Pattern13
    {
        static void Main(string[] args)
        {
            int rows, col, i, j;
            Console.WriteLine("enter the number of rows");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of col");
            col = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= col; j++)
                {
                    if (i == 1 || i == rows || j == 1 || j == col)
                    {
                        Console.Write("*");
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

    //Nprogram

    class Pattern14
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 1 || j == 5 | i == j)
                    {
                        Console.Write("*");
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
      
    
    /// triangleprogram
    

    class Pattern15
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter number of lines:");
            n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for (int j = 1; j <= i;j++)
                {
                    if(j == 1 || j == i || i == n)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }


    //*   * *   * * *   * * * *
    class Pattern16
    {
        static void Main(string[] args)
        {
           for(int i=1;i<=4;i++)
           {
                for (int k = 4; k >= i; k--)
                {
                    Console.Write("  ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write(" *");
                }
                
           }
            Console.WriteLine();
        }
    }
}




