using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //konut kredisi
    class MortgageCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage credit paying plan calculated.");
        }
    }
}
