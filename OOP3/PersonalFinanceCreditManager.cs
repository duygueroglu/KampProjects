using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //ihtiyaç kredisi
    class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal finance credit paying plan calculated.");
        }
    }
}
