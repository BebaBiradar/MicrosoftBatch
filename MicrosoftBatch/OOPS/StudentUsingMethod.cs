using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS
{
    //create student class student  as id ,name and marks create frist method to accept student details ,create second method to
    //display studente method show the data for 3 student
    class StudentUsingMethod
    {
        int Id;
        string Name;
        string Marks;
         
        public void accept()
        {
            Console.WriteLine("enter student name:");
            Name = Console.ReadLine();
            Console.WriteLine("enter the student id:");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter student marks");
            Marks = Console.ReadLine();
        }
        public void show()
        {
            Console.WriteLine("student name:"+Name+"\nstudent id:"+Id+"\nmarks:"+Marks+"\n\n");
        }

    }
    class Details
    {
        static void Main(string[] args)
        {
            StudentUsingMethod d = new StudentUsingMethod();
            for(int i=0;i<=2;i++)
            {
                d.accept();
            }
        }
    }





    class  Stu
    {

        public int id;
        public string name;
        public int marks;

        void details()
        {
            Console.WriteLine("eneter Id:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name:");
            name = Console.ReadLine();
            Console.WriteLine("enter marks:");
            marks = int.Parse(Console.ReadLine());

        }
        void show_details()
        {
            Console.WriteLine("Id:" + id);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("marks:" + marks);
            Console.WriteLine("\n");

        }
        static void Main(string[] args)
        {
            Stu s1 = new Stu();
            s1.details();
            Console.WriteLine("\n");
            Stu s2 = new Stu();
            s2.details();
            Console.WriteLine("\n");
            Stu s3 = new Stu();
            s3.details();
            Console.WriteLine("\n");
            s1.show_details();
            s2.show_details();
            s3.show_details();


                
        }

       
    }
}
