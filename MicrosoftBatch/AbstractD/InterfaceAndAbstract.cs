using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.AbstractD
{


    public interface Icreateable
    {
        static int x = 200;
        void show();
    }
    abstract class Create
    {
        public int y = 300;
        public abstract void Add();
    }   
    class Sum : Create, Icreateable
    {
        public void show()
        {
            Console.WriteLine(Icreateable.x);
        }
        public override void Add()
        {
            Console.WriteLine(y);
        }
        public void sum()
        {
            Console.WriteLine("add");
            int add = Icreateable.x + y;
        }
        internal class InterfaceAndAbstract
        {
            static void Main(string[] args)
            {
                Sum s = new Sum();
                s.sum();
            }
        }


    }
}