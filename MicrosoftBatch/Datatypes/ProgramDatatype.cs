using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.Datatypes
{
    class ProgramDatatype
    {
        static void Main(string[] args)
        {
            byte mbyte = 30;//1byte memory size
            sbyte mbyte2 = -50;
            Console.WriteLine(mbyte);
            Console.WriteLine(mbyte2);

          /*int myint = 6788;//4byte memory size*/

            short myshort = 300;//2 byte memorysize
            short myshort2 = -500;
            Console.WriteLine(myshort+" "+myshort2);

            long mylog = 4567890087777L;//8byte memory size
            long mylog2 = -3445667776788L;
            Console.WriteLine(mylog+" "+mylog2);

            double mydouble = 78.677;//8 byte //after decial number 15 to 16 digite allowed
            Console.WriteLine(mydouble);

            float myfloat = 56.45f;//4 byte//after decimal 5 to 6 digitd allowed
            Console.WriteLine(myfloat);

        }
    }
}
