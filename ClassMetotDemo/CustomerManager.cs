using System;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void AddC(CustomersData customer)
        {
            Console.WriteLine("Customer Added" + " Id = " + customer.CustomerId + " Name = " + customer.CustomerName + " BirthDay = " + customer.CustomerBirthDay);
        }

        public void DeleteC(CustomersData customer)
        {
            Console.WriteLine("Customer Deleted" + " Id = " + customer.CustomerId + " Name = " + customer.CustomerName + " BirthDay = " + customer.CustomerBirthDay);
        }

        public void ListC(CustomersData customer)
        {
            Console.WriteLine("Customer Listed" + " Id = " + customer.CustomerId + " Name = " + customer.CustomerName + " BirthDay = " + customer.CustomerBirthDay);
        }
    }
}