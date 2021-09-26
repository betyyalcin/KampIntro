using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager housingLoanManager = new HousingLoanManager();

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            List<ILoggerService> loggers =new List<ILoggerService> { new SmsLoggerService (), new FileLoggerService()};

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(new TransportCreditManager(),loggers);

            List<ICreditManager> credits = new List<ICreditManager> () {transportCreditManager,housingLoanManager};
            //applicationManager.CreditPreliminaryEvaluation(credits);
        }
    }
}
