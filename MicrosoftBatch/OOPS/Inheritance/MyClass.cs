using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS.Inheritance
{/*
    sealed class Printer
    {
        public void show()
        {
            Console.WriteLine("show");
        }
    }
    class Laser:Printer
    {

    }
    class MyClass
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();
            p.show();

            *//*Laser l = new Laser();
            l.show();*//*

        }
    }


    class Printer1
    {
        public virtual void show()
        {
            Console.WriteLine("show");
        }
    }
    class Laser:Printer1
    {
         sealed public override void show()
        {
            Console.WriteLine("Laser");
        }
    }

    class OfficeJet : Laser
    {
        public override void show()
        {
            Console.WriteLine("My");
        }
    }
    class Myclass
    {
        static void Main(string[] args)
        {
            *//*Laser l new = Laser();
            l.show();*//*
            OfficeJet f = new OfficeJet();
            f.show();
            *//*Printer1 p = new Printer1();
            p.show();*//*
        }
    }*/
}
