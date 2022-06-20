using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop.Dowhile
{
    class Table_1_to_5
    {
        static void Main(string[] args)
        {
            int i = 1, num = 1, table = 1;
            Console.WriteLine("eneter a number");
            do
            {
                table = num * i;
                Console.WriteLine("{0}*{1}={2}",table);
                i++;
            }
            while (i <= 10);
       
        }
    }
}
