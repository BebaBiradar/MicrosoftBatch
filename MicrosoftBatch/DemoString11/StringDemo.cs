using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.String
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            string str = "HELLO C#";//keyword
            string s = "Hello DotNet";//literal
            string s1 = new string("hello my programming");//using new

            int l = s1.Length;
            Console.WriteLine("length"+l);

            string str1 = "Hello";
            string str2 = "Hello";

           /* Console.WriteLine(str1.GetHashCode()+" "+str2.GetHashCode());
            Console.WriteLine(str1==str2);
            str1 = str1 + "C#";
            Console.WriteLine(str1);
            Console.WriteLine(str1==str2);

            Console.WriteLine(str1.GetHashCode()+" "+str2.GetHashCode());*/

            string st = string.Concat(str1, "pune");
            Console.WriteLine(st+" "+str1);

            int x = s1.IndexOf('r');
            Console.WriteLine(s1+" "+x);

            int y = s1.LastIndexOf('r');
            Console.WriteLine(s1+" "+y);

            string s3 = s1.Substring(4);


            Console.WriteLine(s3);
            string s4 = s1.Substring(4, 7);
            Console.WriteLine(s4);
            string mystring = "java,c#c++,pythone";
            string[] s5 = mystring.Split(",");

            foreach(string ss in s5)
            {
                Console.WriteLine(ss);
            }
            Console.WriteLine(string .Join(" "," pune"," ","welcome"));

            string s6 = "   pune  ";
            Console.WriteLine(s6);
            Console.WriteLine(s6.Trim());


            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1.ToLower());

            Console.WriteLine(s1[10]);
        }
    }
}
