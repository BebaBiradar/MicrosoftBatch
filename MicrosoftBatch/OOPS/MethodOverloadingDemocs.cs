using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS
{
    class MethodOverloadingDemocs
    {
        void show()
        {
            Console.WriteLine("show");
        }
        void show(int a,float b)
        {
            Console.WriteLine(a+" "+b);
        }
        void show(int x, int y)
        {
            Console.WriteLine(x+" "+y);

        }
        void show(int x,int y,int z)
        {
            Console.WriteLine((x+y+z)+" "+x+" "+y+" "+z);
        }

        static void Main(string[] args)
        {
            MethodOverloadingDemocs m = new MethodOverloadingDemocs();
            m.show(4, 5);
            m.show();
            m.show(3, 5, 6);
            m.show(4, 9.8f);
        }
    }
}
