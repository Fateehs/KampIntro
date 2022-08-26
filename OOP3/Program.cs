using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalCreditManager = new PersonalCreditManager();
            ICreditManager carLoanManager = new CarLoanManager();
            ICreditManager houseLoanManager = new HouseLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>
                { new DatabaseLoggerService(), new FileLoggerService() };

            ApplyManager applyManager = new ApplyManager();
            applyManager.Apply(personalCreditManager,loggers); // burayı buton olarak simule et

            //burayıda seçeceği kredi tiplerinin olduğu bir liste olarak simule et
            List<ICreditManager> credits = new List<ICreditManager>() {personalCreditManager,carLoanManager };

            //applyManager.CreditInfo(credits);
        }
    }
}
