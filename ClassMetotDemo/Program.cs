using System;
using System.ComponentModel;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomersData customer1 = new CustomersData();
            {
                customer1.CustomerId = 1001;
                customer1.CustomerName = "Fatih";
                customer1.CustomerBirthDay = 2000;
            }

            CustomersData customer2 = new CustomersData();
            {
                customer2.CustomerId = 1002;
                customer2.CustomerName = "Yiğit";
                customer2.CustomerBirthDay = 1999;
            }

            CustomersData customer3 = new CustomersData();
            {
                customer3.CustomerId = 1003;
                customer3.CustomerName = "Selin";
                customer3.CustomerBirthDay = 2000;
            }

            CustomersData customer4 = new CustomersData();
            {
                customer4.CustomerId = 1004;
                customer4.CustomerName = "Derya";
                customer4.CustomerBirthDay = 2001;
            }
            CustomersData customer5 = new CustomersData();
            {
                customer5.CustomerId = 1005;
                customer5.CustomerName = "Kaan";
                customer5.CustomerBirthDay = 2002;
            }
            CustomersData customer6 = new CustomersData();
            {
                customer6.CustomerId = 1006;
                customer6.CustomerName = "Bugra";
                customer6.CustomerBirthDay = 1992;
            }

            CustomersData[] customers = new CustomersData[] { customer1, customer2, customer3, customer4 };
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer Id = " + customer.CustomerId);
                Console.WriteLine("Customer Name = " + customer.CustomerName);
                Console.WriteLine("Customer BirthDay = " + customer.CustomerBirthDay);
                Console.WriteLine("* * * * * * * * * * * * * * * * *");
            }
            Console.WriteLine("Customer Data Listed!");
            Console.WriteLine("* * * * * * * * * * * * * * * * *");

            CustomerManager customerManager = new CustomerManager();
            {
                customerManager.AddC(customer5);
                customerManager.DeleteC(customer6);
                customerManager.ListC(customer3);
            }
            Console.WriteLine("* * * * * * * * * * * * * * * * *");
            Console.WriteLine("Customers Editted!");
            Console.WriteLine("* * * * * * * * * * * * * * * * *");
        }

    }
}
