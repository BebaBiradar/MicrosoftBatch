using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS
{
    class CarMethos
    {
        int model_no;
        string c_name;
        string c_color;
        int price;

        void intput(int id,string name,string color,int pr)
        {
            model_no = id;
            c_name = name;
            c_color = color;
            price = pr;

        }
        void display()
        {
            Console.WriteLine(model_no+""+c_color+" "+c_name+" "+price);
        }
        static void Main(string[] args)
        {
            CarMethos c = new CarMethos();
            c.intput(2034, "BMM", "RED", 786789);
            c.display();
        }

    }
}
