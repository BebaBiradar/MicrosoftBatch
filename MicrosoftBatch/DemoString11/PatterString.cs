using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.String
{
    class PatterString
    {
        static void Main(string[] args)
        {
            string str = "i like india";
            string[] s = str.Split(" ");
            for(int i=0;i<=s.Length;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.WriteLine(s[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
