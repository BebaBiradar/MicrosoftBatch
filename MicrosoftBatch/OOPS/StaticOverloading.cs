using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS
{
    class StaticDemo
    {  
       // int x=10;
        static int x = 10;
        StaticDemo()
        {
            x++;
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            StaticDemo s = new StaticDemo();
            StaticDemo s1 = new StaticDemo();
            StaticDemo s2 = new StaticDemo();
        }
    }

   


    class StaticDemo4
    {
        int x = 10;
        static int y = 20;

        static void mydata()
        {
            StaticDemo4 d = new StaticDemo4();
            Console.WriteLine(d.x+""+y);
            d.show();
        }
        void show()
        {
            y = 500;
            Console.WriteLine(x+""+y);
        }

        static void Main(string[] args)
        {
            /*StaticDemo4 s = new StaticDemo4();
            s.show();*/
            StaticDemo4.mydata();
        }
    }

    class StaticDemo5
    {
        static int x;

        static void get(int x)
        {
            StaticDemo5.x = x;
        }
        void display()
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            StaticDemo5 d = new StaticDemo5();
            get(300);
                d.display();
        }
    }
    class StaticDemo6
    {
        static int x;
        void get(int x)
        {
            StaticDemo6.x = x;
        }
        void display()
        {
            Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            StaticDemo6 d = new StaticDemo6();
            d.get(300);
            d.display();
        }
    }

    /*class StaticDemo7
    {
        static int x;// class variable

        void get(int x)
        {
            StaticDemo7.x = x;
        }
        static void display()
        {
            static int y = 700;
            Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            StaticDemo7 d = new StaticDemo7();
            d.get(300);
            d.display();
        }
    }*/

    
    
    
   
    //write the code to show overloading of static method

    class StaticOverloading
    {
        static void print(string text)
        {
            Console.WriteLine(text);
        }
        static void print(int num)
        {
            Console.WriteLine(num);
        }
        static void print(string text, int number)
        {
            Console.WriteLine(text + "" + number);
        }

        static void Main(string[] args)
        {
            StaticOverloading.print("rani");
            StaticOverloading.print(10);
            StaticOverloading.print("ggg", 45);

        }
    }

    //write a code to check static class contain private constractor


    static class StaticClassDemo1
    {
        /*
         private StaticClassDemo1()
        {
         
        }
        */
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
        }
    }


    static class StaticClassDemo2
    {
        /*
          public StaticClassDemo2()
        {

        }
        */
        static void Main(string[] args)
        {
            Console.WriteLine("helloo");
        }
    }

        /*write the code to create a class which contain one static variable another non-static
            variable perfrom the addition of both the variable in non static method ,create another static method
            and which calculate divison of both the variable access both methods outside the main*/

    /*class StaticClassDemo3
    {
        static int a;
        int b;
        public static void Addition(int x,int y)
        {
            a = x;
            b = y;
            Console.WriteLine("Addition :" + (a + b));
        }
        public static void Division(int x,int y)
        {
            StaticClassDemo3 s = new StaticClassDemo3();
            a = x;
            s.b = y;
            int c = a / s.b;
            Console.WriteLine("Division :" + c);
        }

    }
     internal class Demo
    {
        static void Main(string[] args)
        {
            StaticClassDemo3 so = new StaticClassDemo3();
            so.Addition(10, 5);
            StaticClassDemo3.Division(10, 5);


        }
    }*/


    class Test
    {

        
        
            static Test()
            {
                Console.WriteLine("this is static test");
            }
            public Test(int x)
            {
                Console.WriteLine("hi this is parameter" + x);
            }

            static void Main(string[] args)
            {
                Test t = new Test(200);
                Test t2 = new Test(400);
            }
        
    }

    class StaticConstructorDemo
    {
        static void Main(string[] args)
        {
            Test t = new Test(100);
            //Test t1=new Test();
                
        }
    }

    class StsticClassDemo
    {
        static int x = 100;
        static void Main(string[] args)
        {
            Console.WriteLine(x);
        }
    }

}
