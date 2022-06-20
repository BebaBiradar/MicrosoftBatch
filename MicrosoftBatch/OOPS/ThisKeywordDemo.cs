using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS
{
    class ThisKeywordDemo
    {
        int model_no;
        string c_name;
        string c_color;
        int price;

        void input(int model_no,string c_name,string c_color,int price)
        {
            this.model_no = model_no;
            this.c_name = c_name;
            this.c_color = c_color;
            this.price = price;
            this.display();
        }
        void display()
        {
           // this.input(2343, "audi", "black", 78993003);
            Console.WriteLine(model_no+" "+c_color+" "+c_name+" "+price);
           // Console.WriteLine(id);
        }
        static void Main(string[] args)
        {
            ThisKeywordDemo t = new ThisKeywordDemo();
            //t.input(2034,"bgh","grfd",345678099)
           // t.display();

        }
    }

    class Emp
    {
        int id;
        string name;

        public Emp(int id,string name)
        {
            this.id = id;
            this.name = name;

        }
        public Emp()
        {
            Console.WriteLine("i am default:");
        }
        void display()
        {
            Console.WriteLine(id+" "+name);
        }
        static void Main(string[] args)
        {
            Emp e = new Emp();
            Emp e1 = new Emp(101, "amit");
            e1.display();
        }
    }

    class Emp2
    {
        int id;
        string name;
        public Emp2(int id,string name):this()
        {
            this.id = id;
            this.name = name;
            display();
        }
        public Emp2():this(100,200,"pune")
        {
            Console.WriteLine("i am defoult");
        }
        public Emp2(int i,int j,string nm)
        {
            Console.WriteLine(i + " " + j + " " + nm);
        }
        void display()
        {
            Console.WriteLine(id+" "+name);
        }
        static void Main(string[] args)
        {
            //Emp2 e = new Emp2();
            Emp2 e1 = new Emp2(101, "ghh");
            //e1.display();

        }
    }
}
