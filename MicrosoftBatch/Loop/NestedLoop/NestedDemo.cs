using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop.NestedLoop
{
    class NestedDemo
    {
        static void Main(string[] args)
        {
            /*for(init;cond;Inr/decimal)
            {
                for (init; cond; Ic/ decimal)
                {
                    Console.WriteLine();
                }
            }*/


           for(int i=1;i<=3;i++)
            {
                for(int j=1;j<=2;j++)
                {
                    Console.WriteLine(j);
                }
            }


        }
    }
}
