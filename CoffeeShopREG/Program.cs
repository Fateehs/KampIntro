using System;
using CoffeeShopREG.Abstract;
using CoffeeShopREG.Concrete;
using CoffeeShopREG.Entities;

namespace CoffeeShopREG
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer{DateOfBirth =new DateTime(1985,1,6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "28861499108"});
        }
    }
}
