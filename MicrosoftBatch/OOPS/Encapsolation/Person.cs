using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS.Encapsolation
{
    //using constuctor (aggregation)
    class Address
    {
        public int pincode;
        public string city;

        public Address(int pincode, string city)
        {
            this.pincode = pincode;
            this.city = city;
        }

        public void show()
        {
            Console.WriteLine(pincode + " " + city);
        }
    }
    class Person
    {
        int id;
        string name;
        Address adr;


        public Person(int id, string name, Address adr)
        {
            this.id = id;
            this.name = name;
            this.adr = adr;
        }

        void display()
        {
            /*Console.WriteLine(id+" "+name+" ");
            adr.show();*/
            Console.WriteLine(id + " " + name + " " + adr.pincode + " " + adr.city);
        }

        static void Main(string[] args)
        {
            /*Address a = new Address(3456,"pune");
            Person p = new Person(345, "hnkui", a);*/
            //Console.WriteLine(p);
            Person p = new Person(348, "nuihh", new Address(5679, "pue"));

            p.display();


        }
    }
}

