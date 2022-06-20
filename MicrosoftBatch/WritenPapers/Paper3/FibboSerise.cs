using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.WritenPapers.Paper3
{
    class FibboSerise
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of term");
            int n = int.Parse(Console.ReadLine());
            int i, t1 = 0, t2 = 1,nextterm;
            for(i=1;i<=n;++i)
            {
                Console.WriteLine(t1+" ");
                nextterm = t1 + t2;
                t1 = t2;
                t2 = nextterm;
            }
        }
    }
}
