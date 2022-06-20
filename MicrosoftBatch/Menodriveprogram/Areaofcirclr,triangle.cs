using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Menodriveprogram
{
    class Areaofcirclr_triangle
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                int choice;
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("Calculate areas:");
                Console.WriteLine("1.circle\n 2.rectangle\n3.triangle\n 4.square");
                Console.WriteLine("enter your number 1");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter your number 2");
                int num2 = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("area of circle:" + (3.14f * num1 * num2));
                        break;
                    case 2:
                        Console.WriteLine("area of reactangle:" + (num1 * num2));
                        break;
                    case 3:
                        Console.WriteLine("area of tringle:" + (0.5f * num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("area of square:" + (num1 * num2));
                        break;
                    default:
                        Console.WriteLine("invalide choice");
                        break;

                     
                }
                Console.WriteLine("do you want to continue:");
                ch = Console.ReadLine()[0];

            } while (ch == 'y' || ch == 'Y');
        }
    }
}
