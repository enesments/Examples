using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            ICreditBaseManager requirementCreditManager = new RequirementCreditManager();
            ICreditBaseManager carCreditManager = new CarCreditManager();
            ICreditBaseManager houseCreditManager = new HouseCreditManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService>() { new DatabaseLoggerService(),new SmsLoggerService(), new FileLoggerService()};  
            ICreditBaseManager bussinessCreditManager = new BussinessCreditManager();
            ApplicationManager applicationManager = new ApplicationManager();
           applicationManager.Application(bussinessCreditManager,loggers);
           

            List<ICreditBaseManager> credits = new List<ICreditBaseManager>() {requirementCreditManager,carCreditManager,houseCreditManager };
           // applicationManager.CreditInformation(credits);

        }
    }
}
