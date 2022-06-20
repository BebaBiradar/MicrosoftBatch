using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.DemoString11
{
    class ReversWord
    {
        static void Main(string[] args)
        {
            string str = "C# is eassy";
            string[] str1 = str.Split(" ");
            string revers = "";
            for(int i=0;i<str1.Length;i++)
            {
                string word = str1[i];
                string myword = "";
                for(int j=word.Length-1;j>0;j++)
                {
                    myword = myword + word[j];
                }
                revers = revers + myword + " ";
            }
            Console.WriteLine(revers);
        }
    }
}
