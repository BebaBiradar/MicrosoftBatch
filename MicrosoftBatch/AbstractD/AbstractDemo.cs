using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.AbstractD
{
    abstract class Animal
    {
        public int x = 100;
        public static int y = 500;

        public Animal()
        {
            Console.WriteLine("Animal Constractore");
        }
        public abstract void show();//abstarct method
        public void Myanimal()//non abstract method or concrent method
        {
            Console.WriteLine("my animal");
        }
    }
    class Dog : Animal
    {
        public Dog() : base()
        {
            Console.WriteLine("Dog constructore");
        }
        public override void show()
        {
            Console.WriteLine("Dog" + " "+x+" "+y);
        }
    }
   class AbstractDemo
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.show();
            a.Myanimal();
        }
    }




   
}
