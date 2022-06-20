using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.AbstractD.InterfaceD
{
    
        public interface Imoveable
        {
            static int x;
            void show();

            static void MyMethod()
            {
                Console.WriteLine("my static interface method");
            }
            void foo()
            {
                Console.WriteLine("foo method");
            }
        }
        class Car : Imoveable
        {
            public void show()
            {
                Imoveable.x = 400;
                Console.WriteLine("my iterface method " + Imoveable.x);
            }
        }
        class InterfaceDemo
        {
            static void Main(string[] args)
            {
                Imoveable m = new Car();
                m.show();
                Imoveable.MyMethod();
                m.foo();
            }
        }
    
}
