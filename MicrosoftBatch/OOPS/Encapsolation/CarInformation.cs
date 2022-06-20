using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS.Encapsolation
{
    class Car
    {
        private int modelno;
        private string name;
        private string color;
        private double price;

        public int Modelno
        {
            get { return modelno; }
            set { modelno = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

    }
    class CarInformation
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Modelno = 23;
            c.Name = "hundai";
            c.Color = "Black";
            c.Price = 3.4;
            Console.WriteLine(c.Modelno+" "+c.Name+" "+c.Color+" "+c.Price);
        }
    }
}
