using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop.Dowhile
{
    class DoWhileDemo
    {
        static void Main(string[] args)
        {
            /* initialization
          do
          {
          logic
           increment/decrement
          }while(condition);*/



            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i > 10);
        }

    }
}
