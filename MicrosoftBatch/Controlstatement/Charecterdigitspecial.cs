using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Controlstatement
{
    class Charecterdigitspecial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a charecter");
            char cr = char.Parse(Console.ReadLine());
            if ((cr >= 'a' && cr <= 'z') || (cr >= 'A' && cr <= 'Z'))
            {
                Console.WriteLine("this is a charecter");
            }
            else if (cr >= '0' && cr <= '9')
            {
                Console.WriteLine("this is digite");
            }
            else
            {
                Console.WriteLine("this is special symbole");
            }
        }
    }
}
