using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
     class Customer
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string City { get; set; }
        public double BillAmount { get; set; }
        public Customer(int custId, string custName, string city, double billAmount)
        {
            this.CustId = custId;
            this.CustName = custName;
            this.City = city;
            this.BillAmount = billAmount;
        }
        
        static void Main()
        {
            Customer c1=new Customer(101, "David", "New York", 5000);
            Customer c2 = new Customer(102, "Smith", "New York", 6000);
            Customer c3 = new Customer(103, "Richards", "New York", 7000);
            Customer c4 = new Customer(104, "John", "New York", 8000);

            List<Customer> Customers = new List<Customer>();
            Customers.Add(c1);
            Customers.Add(c2);
            Customers.Add(c3);
            Customers.Add(c4);

            foreach(Customer obj in Customers)
            {
                Console.WriteLine(obj.CustId+" "+obj.CustName+" "+obj.City+" "+obj.BillAmount);
               //Console.WriteLine(obj);
            }
        }
    }
}
