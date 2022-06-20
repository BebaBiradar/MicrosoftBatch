using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS.Encapsolation
{
    class Student
    {
        private int id;
        private string name;
        private double per;

        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public double Per
        {
            get;
            set;
        }
    }
    class StudentInfo
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 3;
            s.Name = "ddd";
            s.Per = 56.77;
            Console.WriteLine(s.Id+" "+s.Name+" "+s.Per);

        }
    }
}
