using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.DemoString11
{
    class ReversString
    {
        static void Main(string[] args)
        {
            string str = "india is my country";
            char[] ch = str.ToCharArray();
            int j = ch.Length - 1;
            for(int i=0;i<ch.Length/2;i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;

            }
            Console.WriteLine(string.Join(" ",ch));
            string st = new string(ch);
            Console.WriteLine(st);


        }
    }

    class Revers1
    {
        static void Main(string[] args)
        {
         string str= "india is my country";

            string revers = "";
            for(int i=0;i<str.Length;i++)
            {
                revers = str[i] + revers;
            }
            Console.WriteLine(revers);
        }
    }

    class Revers2
    {
        static void Main(string[] args)
        {
            string str = "india is my country";

            string revers = "";
            for (int i = str.Length-1; i>=0; i--)
            {
                revers =  revers+str[i];
            }
            Console.WriteLine(revers);
        }
    }


   
}
