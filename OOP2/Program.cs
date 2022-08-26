using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.CustomerName = "Fatih";
            customer1.CustomerLastName = "Selvi";
            customer1.CitizenNo = "2131255552";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "9323515152";
            customer2.CompanyName = "Ekermak";
            customer2.TaxNumber = "8225699-74C";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            

        }
    }
}
