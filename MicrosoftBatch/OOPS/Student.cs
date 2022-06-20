using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS
{
    class Student
    {
        public int id;
        public string name;
        public double marks;
        static void Main(string[] args)
        {
            Student stu;
            stu=new Student();

            stu.id = 100;
            stu.name = "nikita";
            stu.marks = 78.56;
            Console.WriteLine(stu.id+""+stu.name+""+stu.marks);

            Student s = new Student();

            s.id = 200;
            s.name = "yash";
            s.marks= 56.34;
            Console.WriteLine(s.id+" "+s.name+" "+s.marks);



        }
    }
}
