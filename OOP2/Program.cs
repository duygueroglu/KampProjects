using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.CustomerId = 1;
            customer1.CustomerNo = "12345";
            customer1.CustomerName = "Duygu";
            customer1.CustomerSurname = "Eroğlu";
            customer1.TcNumber = "12345678910";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.CustomerId = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "kodlama.io";
            customer2.TaxNo = "1234567890";

            //real customer - corporate customer
            //SOLID

            Customer customer3 = new RealCustomer();    //reference no in memory
            Customer customer4 = new CorporateCustomer();   //reference no in memory

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
