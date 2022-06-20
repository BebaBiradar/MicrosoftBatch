using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS.Inheritance
{
    //Multiple Inheritace
    class Laptop
    {
        protected int price = 45000;
    }
    class Dell:Laptop
    {
        public void show()
        {
            price = 35000;
            Console.WriteLine("Dell="+price);
        }
    }
    class HP:Laptop
    {
        public void display()
        {
            price = 56000;
            Console.WriteLine("Hp=" +price);
        }
    }
    class Accer : Laptop
    {
        public void output()
        {
            price = 50000;
            Console.WriteLine("Accer "+price);
        }
    }
    class Mylaptops
    {
        static void Main(string[] args)
        {
            Accer a = new Accer();
            a.output();
            Dell d = new Dell();
            d.show();
            HP p = new HP();
            p.display();

        }
    }
}
