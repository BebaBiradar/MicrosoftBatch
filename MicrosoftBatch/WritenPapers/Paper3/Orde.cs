using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.WritenPapers.Paper3
{
    class Orde
    {
        private int order_id;
        private string city;
        private string cus_name;
        private bool isDelivered;

        public int Id
        {
            get { return order_id; }
            set {order_id = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Customer
        {
            get { return cus_name; }
            set { cus_name = value; }
        }
         public bool Deliverd
        {
            get { return isDelivered; }
            set { isDelivered = value; }
        }      
    }
    class DeliveryInfo
    {
        static void Main(string[] args)
        {
            Orde o = new Orde();
            o.Id = 134556777;
            o.City = "pune";
            o.Customer = "happy";
            o.Deliverd = true;
            Console.WriteLine(o.Id+" "+o.City+" "+o.Customer+" "+o.Deliverd);


        }
    }
}
