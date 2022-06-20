using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop.NestedLoop
{
    class SumFact
    {
        static void Main(string[] args)
        {
            
            //find sum of factorial 1!2!3!4!
            int sum = 0;
            for (int i= 1; i <= 5; i++) 
            {
                int fact = 1;
                for (int j = 1; j <= i; j++) 
                {
                  fact = fact * j;
                }
                sum = sum + fact;
            }
            Console.WriteLine(sum);
        }
    }
}
