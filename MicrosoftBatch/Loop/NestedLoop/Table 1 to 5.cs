using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop.NestedLoop
{
    class Table_1_to_5
    {
        static void Main(string[] args)
        {
            int x = 0;
           
            for (int i = 1; i <= 5; i++)
            {
                for(int j=1;j<=10;j++)
                {
                    x = i * j;
                    Console.WriteLine(x+"");
                }
                Console.WriteLine(" ");
            }
        }
           

    }
}
