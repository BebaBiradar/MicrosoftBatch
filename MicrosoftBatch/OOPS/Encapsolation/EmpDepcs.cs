using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS.Encapsolation
{

    class Department
    {
        private int did;
        private string dname;

        public int Did
        {
            get { return did; }
            set { Did = value; }
        }

        public string Dname
        {
            get { return dname; }
            set { dname = value; }
        }
    }
    class EmpDepcs
    {
        private int id;
        private string name;
        private Department dept;


        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }  
        public Department Dept
        {
            get { return dept; }
            set { dept = value; }
        }


        static void Main(string[] args)
        {
            Department d = new Department();
             d.Did = 10;
             d.Dname = "sales";
             EmpDepcs e = new EmpDepcs();
             e.Id = 122;
             e.Name = "feer";
             e.Dept = d;
             Console.WriteLine(e.Id+" "+e.Name+" "+d.Did+" "+d.Dname+" ");

            /*EmpDepcs e = new EmpDepcs();
             e.Id = 1;
             e.Name = "dff";
             e.Dept = new Department();
             e.Dept.Did = 133;
             e.Dept.Did = 12;
             e.Dept.Dname = "dgg";
             Console.WriteLine(e.Id + " " + e.Name + " "e.Dept.Did+" "+e.Dept.Dname);*/

            /*EmpDepcs e = new EmpDepcs();
            e.Id = 1;
            e.Name = "def";
            e.Dept = new Department();
            Department d = e.Dept;
            d.Did = 23;
            d.Dname = "hr";*/

        }

    }
}
