using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch
{
    class StringBuilderDemoTest
    {
        static void Main(string[] args)
        {
            //StringBuilder sb = new StringBuilder();
        //StringBuilder sb1 = new StringBuilder("Hello");


            string s = "pune";
            StringBuilder sb = new StringBuilder(s);
            Console.WriteLine(sb);
            sb.Append("City");
            Console.WriteLine(sb);
            sb.AppendLine(" for Fun");
            Console.WriteLine(sb);


            sb.Insert(6, "c#");
            Console.WriteLine(sb);

            sb.Remove(2, 6);
            Console.WriteLine(sb);

            for(int i=0;i<sb.Length;i++)
            {
                Console.WriteLine(sb[i]);
            }
            //string str = sb.ToString();
        }
    }


    class  Demo
    {
        static void Main(string[] args)
        {
            string s = "pune";
            StringBuilder sb = new StringBuilder(s);
            Console.WriteLine(sb);
            StringBuilder sb2 = new StringBuilder("pune");
            Console.WriteLine(sb2);
            Console.WriteLine(sb.Equals(sb2));
            Console.WriteLine(sb==sb2);

        }
    }
}
