using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Controlstatement
{
    class Checkpositivenegation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if(num>0)
            {
                Console.WriteLine("positeve");
            }
            else if(num<0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
