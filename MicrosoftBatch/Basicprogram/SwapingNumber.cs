using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Basicprogram
{
    class SwapingNumber
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine("Befor swap a="+a+" b="+b);
             a = int.Parse(Console.ReadLine());
             b = int.Parse(Console.ReadLine());
            a = a + b;//a=15(5+10)
            b = a - b;//b=5(15-10)
            a = a - b;//a=10(15-5)
            Console.WriteLine("after swap a ="+a+" b="+b);


        }

    }

    class Swapingwith
    {
        static void Main(string[] args)
        {
            int a=5, b=10, temp;
            Console.WriteLine("befor swap a="+a+" b="+b);
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("after swap a="+a+" b="+b);
        }
    }
}
