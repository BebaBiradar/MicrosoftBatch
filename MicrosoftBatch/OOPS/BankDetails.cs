using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS
{
    class BankDetails
    {
        public long acc_no;
        public string acc_type;
        public string cust_name;
        public long bal;
        public long total_bal;
        public void input(long accno, string acctype,string custname,long balance)
        {
            acc_no = accno;
            acc_type = acctype;
            cust_name = custname;
            bal = balance;

        }
        void display()
        {
            Console.WriteLine("account nuber"+acc_no);
            Console.WriteLine("account type"+acc_type);
            Console.WriteLine("customer name"+cust_name);
            Console.WriteLine("balance"+bal);
        }
        void withdroDeposite()
        {
            Console.WriteLine("welcome to my bank\n what you want to do 1.withdrow 2.deposite");
            int n = int.Parse(Console.ReadLine());
            if(n==1)
            {
                Console.WriteLine("enter the amount you want to withdraw");
                long amt = long.Parse(Console.ReadLine());
                long total_bal = bal + amt;
                Console.WriteLine("Avalaible balance is="+total_bal); 
            }
            else
            {
               if(total_bal>500)
                {
                    Console.WriteLine("enter the amount you want to deposit");
                    long amt=long.Parse(Console.ReadLine());
                   
                    long total_bal = bal - amt;
                    Console.WriteLine("available balance is="+total_bal);

                }
               else
                {
                    Console.WriteLine("oops you have the low balance in your account");
                }
                 

                
            }
            
                
     
        }
        static void Main(string[] args)
        {
            BankDetails a = new BankDetails();
            a.input(567877898, "withdraw", "khushi", 50000);
            a.display();
            a.withdroDeposite();


        }
    }

    
}
