using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS
{
    class Animal
    {
        public int legs = 4;
        private int eye = 2;
        protected int ear = 2;

        static void Main(string[] args)
        {
            Animal a = new Animal();
            Console.WriteLine("hi" + a.legs + " " + a.eye + " " + a.ear);

        }

    }
    class AcessModifierDemo:Animal
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Console.WriteLine(a.legs);
            // Console.WriteLine(a.eye);//error private
            //Console.WriteLine(a.ear);
            AcessModifierDemo d = new AcessModifierDemo();
            Console.WriteLine(d.ear);

        }
    }
}
