using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS
{
    class UserMethod
    {
        int x;
        int y;
        public void Addition()
        {
            Console.WriteLine("Addition:"+(10+30));
        }

        public void Substraction(int x,int y)
        {
            this.x = x;
            this.y = y;
            showSubstraction();
        }
        void showSubstraction()
        {
            Console.WriteLine(x-y);
        }
        public float Multiplication()
        {
            return 1.2f * 3;
        }
        public  void showMultiplication()
        {
            Console.WriteLine(this.Multiplication());
        }
        public double div(double x,double y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            UserMethod u = new UserMethod();
            u.Addition();
            u.Substraction(6, 2);
            u.showMultiplication();

            double ans = u.div(4.5, 1.2);
            Console.WriteLine(ans);
        }
    }
}
