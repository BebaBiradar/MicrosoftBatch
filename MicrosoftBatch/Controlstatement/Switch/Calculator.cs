using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Controlstatement.Switch
{
    class Calculator
    {
        static void Main(string[] args)
        {
            char Operator;
            float n1, n2, result = 0;
            Console.WriteLine("enter any operatore:");
            Operator = char.Parse(Console.ReadLine());
            Console.WriteLine("enter the values of operand n1 and n2:");
            n1 = float.Parse(Console.ReadLine());
            n2 = float.Parse(Console.ReadLine());

            switch (Operator)
            {
                case '+':
                    result = n1 + n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
                case '*':
                    result = n1 * n2;
                    break;
                case '/':
                    result = n1 / n2;
                    break;
                default:
                    break;

            }
            Console.WriteLine(n1 + "" + Operator + "" + n2 + ":" + result);
        }
    }
}
