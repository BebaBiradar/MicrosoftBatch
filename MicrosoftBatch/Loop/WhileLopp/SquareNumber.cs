using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Loop.WhileLopp
{
    class SquareNumber
    {
        static void Main(string[] args)
        {
            int  i = 1;
           
          
            while(i<100)
            {
                Console.WriteLine(i*i);
                i++;
            }
        }
    }
}
