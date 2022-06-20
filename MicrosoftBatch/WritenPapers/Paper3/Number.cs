using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.WritenPapers.Paper3
{
    class Number
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i < 100; i++)
            {
                if ((i % 5 != 0) && (i % 10 != 0))
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
