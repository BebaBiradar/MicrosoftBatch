using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.WritenPapers.Paper3
{
    class FactSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the term");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
           
            for(int i=1;i<=n;i++)
            {
                int fact = 1;
                for(int j=1;j<=i;j++)
                {
                    fact = fact * j;
                }
                Console.WriteLine("factorial of"+i+"="+fact);
                sum = sum + fact;
            }
            Console.WriteLine("factoral sum="+sum);
        }
    }
}
