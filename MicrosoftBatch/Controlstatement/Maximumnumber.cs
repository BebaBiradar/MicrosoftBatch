using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Controlstatement
{
    class Maximumnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1 st num");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter 2 num");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 3 rd num");
            int num3 = int.Parse(Console.ReadLine());
            int max = 0;
            if (num1 > num2 && num1 > num3)
            {
                max = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                max = num2;
            }
            else
            {
                max = num3;
            }
            Console.WriteLine("max number is="+max);

        }   

    }
}
