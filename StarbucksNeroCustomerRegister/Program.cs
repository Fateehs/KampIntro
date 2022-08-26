using System;
using StarbucksNeroCustomerRegister.Abstract;
using StarbucksNeroCustomerRegister.Concrete;
using StarbucksNeroCustomerRegister.Entities;

namespace StarbucksNeroCustomerRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer{BirthDateTime = new DateTime(2000,09,13),FirstName = "Fatih",LastName = "Selvi",NationalityId = "28861499108"});
        }
    }
}
