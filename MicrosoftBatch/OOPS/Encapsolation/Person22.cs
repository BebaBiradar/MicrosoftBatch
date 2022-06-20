using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS.Encapsolation
{
    class Address2
    {
        private int id;
        private int pincode;
        private string name;
        private string city;
        private string add;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Add
        {
            get { return add; }
            set { add = value; }
        }
    }
    class Person22
    {
        static void Main(string[] args)
        {
            Address2 a = new Address2();
            a.Id = 1;
            a.Pincode = 1233;
            a.Name = "Raj";
            a.City = "Hydrabad";
            a.Add = "ABC colony Ameerpet Hydrabad";
            Console.WriteLine(a.Id + "  " + a.Pincode + "   " + a.Name + "  " + a.City + "  " + a.Add);
        }
    }
}
