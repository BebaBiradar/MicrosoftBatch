using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Controlstatement.Switch
{
    class Characteusingswitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter value");
            string input=Console.ReadLine();
            switch(input)
            {
                case "happy": Console.WriteLine("happy");
                    break;
                case "new": Console.WriteLine("new");
                    break;
                case "year": Console.WriteLine("year");
                    break;
                default: Console.WriteLine("welcome");
                    break;

            }
        }
    }

    class Arthmatic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2 nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.WriteLine("sunstraction=" + (num1 - num2));
                    break;
                case 2: Console.WriteLine("division=" + (num1 / num2));
                    break;
                case 3: Console.WriteLine("multiplication=" + (num1 * num2));
                    break;
                case 4: Console.WriteLine("addition="+(num1+num2));
                    break;
                default: Console.WriteLine("invalid choice");
                    break;
            }
        }
    }
}
