using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //esnaf kredisi
    class ArtisanCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Artisan credit calculate.");
        }
    }
}
