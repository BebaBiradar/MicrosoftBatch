using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS.Inheritance
{
    //Overridingpogram using virtual
    class Vahical
    {

        public virtual void run()
        {
            Console.WriteLine("vehical is running...");
        }

    }
    class Car:Vahical
    {
        public override void run()
        {
            Console.WriteLine("car is running.....");
        }
    }
    class Truck:Vahical
    {
        public override void run()
        {
            Console.WriteLine("truck is running....");
        }
    }
    class OverridingDemo
    {
        static void Main(string[] args)
        {

            Vahical v = new Car();
            v.run();
            /*Car c = new Car();
            c.run();*/

        }
    }
}
