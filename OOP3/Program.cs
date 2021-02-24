using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaces can keep reference of the class that implement it.

            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(new ArtisanCreditManager(), databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCreditManager, transportCreditManager};
            //applicationManager.MakeCreditPreNotification(credits);
            
        }
    }
}
