using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Controlstatement
{
    class Vowelandcons
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "enter a charecter:");
            char ch = char.Parse(Console.ReadLine());
            
            if(ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonent");
            }
        }
    }

    class Vote
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter yhe weight");
            int wt = int.Parse(Console.ReadLine()); ;
            Console.WriteLine("enter the age");
            int age = int.Parse(Console.ReadLine());
            if(age>18 && wt>50)
            {
                Console.WriteLine("allowed");
            }
            else
            {
                Console.WriteLine("not allowed");
            }
        }
    }
}
