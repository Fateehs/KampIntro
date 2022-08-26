using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopREG.Abstract;
using CoffeeShopREG.Entities;
using MernisServiceReference;

namespace CoffeeShopREG.Concrete
{
    internal class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
