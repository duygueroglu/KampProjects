using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //inheritance, CorporateCustomer is a customer, CorporateCustomer inherites/extends Customer
    class CorporateCustomer:Customer
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }

    }
}
