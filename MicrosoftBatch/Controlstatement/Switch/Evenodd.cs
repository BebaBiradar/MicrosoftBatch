using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Controlstatement.Switch
{
    class SwitchEvenOdd
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter any number to check even or odd");
            num = int.Parse(Console.ReadLine());
            switch(num%2)
            {
                case 0:
                    Console.WriteLine("number is even");
                    break;
                case 1:
                    Console.WriteLine("number is odd");
                    break;
            }
        }

            
    }
}
