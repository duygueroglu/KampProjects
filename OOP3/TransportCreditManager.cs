using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //taşıt kredisi
    class TransportCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Transport credit paying plan calculated.");
        }
    }
}
