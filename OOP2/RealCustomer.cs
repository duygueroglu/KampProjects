using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //inheritance, RealCustomer is a customer, RealCustomer inherites/extends Customer
    class RealCustomer :Customer
    {
        public string TcNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
