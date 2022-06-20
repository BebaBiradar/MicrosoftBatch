using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Menodriveprogram
{
    class AddSubDivMul
    {
        static void Main(string[] args)
        {

            char ch;
            do
            {
                int choice;
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("1.Addition\n2.Substraction\n3Multiplication\n4.Division");
                Console.WriteLine("enter your choice");
                Console.WriteLine("eneter the number 1");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the number 2");
                int num2 = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition=" + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Substraction=" + (num1 + num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication=" + (num1 + num2));
                        break;
                    case 4:
                        Console.WriteLine("Division+" + (num1 + num2));
                        break;
                    default:
                        Console.WriteLine("invalide choice");
                        break;
                }
                Console.WriteLine("do you want to continue:");
                ch = Console.ReadLine()[0];
                

            } while( ch == 'y' || ch == 'Y');
        }
    }
    
}
