using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS
{
    class Cardetails
    {
     public int modelno;
     public string carname;
     public string carcolor;
     public double prize;

        static void Main(string[] args)
        {
            Console.WriteLine(" Hyndai car details");
            Cardetails c = new Cardetails();
            c.modelno = 10;
            c.carname = "Hyndai";
            c.carcolor = "Black";
            c.prize = 1.7;
            Console.WriteLine(c.carname+" "+c.modelno+" "+c.carcolor+" "+c.prize);


            Console.WriteLine(" Maruti suzuki car details");
            Cardetails d = new Cardetails();
            d.modelno = 8;
            d.carname = "Maruti suzuki";
            d.carcolor = "Read";
            d.prize = 12.5;
            Console.WriteLine(d.carname + " " + d.modelno + " " + d.carcolor + " " + d.prize);


        }

    }
}
