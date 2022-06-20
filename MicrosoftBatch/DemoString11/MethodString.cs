using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.String
{
    class MethodString
    {
        static void Main(string[] args)
        {
           string str = "Hello";
            string str1 = new string("hello");


            Console.WriteLine(str==str1);
            Console.WriteLine(str.Equals(str1));
            int i= str.CompareTo(str1);
            Console.WriteLine(i);
                
        }
    }
}
