using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarbucksNeroCustomerRegister.Entities;

namespace StarbucksNeroCustomerRegister.Abstract
{
    internal interface ICustomerService
    {
        void Save(Customer customer);
    }
}
