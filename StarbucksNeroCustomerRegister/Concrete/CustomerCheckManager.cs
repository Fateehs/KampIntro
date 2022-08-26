using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MernisServisReference;
using StarbucksNeroCustomerRegister.Abstract;
using StarbucksNeroCustomerRegister.Entities;

namespace StarbucksNeroCustomerRegister.Concrete
{
    public class CustomerCheckManager:ICustomerCheckService 
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
