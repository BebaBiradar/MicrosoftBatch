using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.ArrayDemo
{
    class ArrayReversDemo
    {
        static void Main(string[] args)
        {
            char[] ch = { 'e', 't', 'u', 'd', 'n' };
            Console.WriteLine(string.Join(" ",ch));
            Console.WriteLine();
            Console.WriteLine("//////////////////////////");
            int j = ch.Length - 1;
            for(int i=0;i<ch.Length/2;i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;
            }

            //print array in revers order

            /* for(int i=ch.Length-1;i>=0;i--)
             {
                 Console.WriteLine(ch[i]+" ");
             }*/

            Console.WriteLine();
            Console.WriteLine("////////////////////");
            Console.WriteLine(string.Join(" ", ch));
            Console.WriteLine("-------------------");
            for(int i=0;i<ch.Length;i++)
            {
                Console.WriteLine(ch[i]);
            }
                
        }
    }
}
