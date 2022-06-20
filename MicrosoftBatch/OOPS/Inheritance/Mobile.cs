using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS.Inheritance
{
    //single inheritance and Multilevelinheritance
    class Mobile
    {
        protected string memory ="128GB";
    }
    class Apple:Mobile
    {
       protected string camera = "3.5px";
       /* void show()
        {
            Console.WriteLine("Memory "+memory+" "+camera);
        }
        static void Main(string[] args)
        {
            Apple a = new Apple();
            a.show();
        }*/
       class MyiPhonePro:Apple
        {
            string screen = "4.5inch";
            void display()
            {
                Console.WriteLine(memory+" "+camera+" "+screen);
            }
            static void Main(string[] args)
            {
                MyiPhonePro p = new MyiPhonePro();
                p.display();
            }
        }
    }
}
