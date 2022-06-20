using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS.Encapsolation
{
    class Employee
    {
        private int id;
        private string name;//field
        private int salary;

        public int Id//get method
        {
            get { return id; }//get method
            set { id = value; }//set method

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
    class EmpInformation
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Id = 2000;
            e.Name = "hdgdg";
            e.Salary = 2334;
            Console.WriteLine(e.Id+" "+" "+e.Name+" "+e.Salary);
        }
    }



    class Stu
    {
        private int id;
        private string name;//field
        private double per;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Per { get => per; set => per = value; }
    }

    class StudInfo
    {
        static void Main(string[] args)
        {
            Stu s = new Stu();
            s.Id = 3;
            s.Name = "dee";
            s.Per = 67.45;
            Console.WriteLine(s.Id + " " + " " + s.Name + " " + s.Per);
        }
    }
}
