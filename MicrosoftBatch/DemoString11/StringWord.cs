using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.String
{

    class StringWord
    {
        static void Main(string[] args)
        {
            int a = 0, myWord = 1;
            string str = "India  is my country";
            while(a<=str.Length-1)
            {
                if (str[a] == ' ' && str[a] == ' ' && str[a] == ' ')
                {
                    myWord++;
                }
                myWord++;
                        
            }
            Console.WriteLine("number of words in the string={0}\n",myWord);
        }
    }

    //this one is correct for stringWord
    class Program
    {
        static void Main(string[] args)
        {
            string sen = "India is my country";
            int count = 0;
            for (int i = 0; i < sen.Length - 1; i++)
            {
                if (sen[i] == ' ' && Char.IsLetter(sen[i + 1]) && (i > 0))
                    count++;

            }
            count++;
             Console.WriteLine("total number of word in the given string:"+count);
        }
            
    }
}
