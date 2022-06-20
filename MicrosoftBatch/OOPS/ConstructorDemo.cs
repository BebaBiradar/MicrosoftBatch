using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS
{
    class ConstructorDemo//parameterised constractor
    {
        public ConstructorDemo(int x)
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            ConstructorDemo c = new ConstructorDemo(10);
        }
    }

    class Demo
    {
        public int x;
        public void input(int x)
        {
            this.x = x;
        }
        public void show()
        {
            Console.WriteLine(x);
        }
    }
    class Outsidemain
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.input(450);
            d.show();
        }
    }





}
