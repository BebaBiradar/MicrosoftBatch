using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop.WhileLopp
{
    class Serise
    {
        static void Main(string[] args)
        {
            int num, count = 1;
            Console.WriteLine("enter a integer number :");
            num = int.Parse(Console.ReadLine());
            while (count <= num)
            {
                Console.WriteLine((count * count));
               
           
                count++;
            }   
        }
    }


    class SeriseNumber
    {
        //write a code to display following serice 1,2,9,4,25,6
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i * i);
                }



            }
        }
    }

    class SeriseNumberEvenOdd
    {
        static void Main(string[] args)
        {
            int i;
            for(i=1;i<11;i++)
            {
                Console.WriteLine((i*i)+(i*i*i));
            }

        }
    }
}
