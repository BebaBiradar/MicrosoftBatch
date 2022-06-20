using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS.Encapsolation
{
    class EmpInformation22
    {
        int id;
        string name;
        int salary;


        public EmpInformation22(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        void display()
        {
            Console.WriteLine(id+" "+name+" "+salary);
        }
        static void Main(string[] args)
        {
            EmpInformation22 e = new EmpInformation22(22, "mohan", 23433);
            e.display();
        }
    }
    
}
