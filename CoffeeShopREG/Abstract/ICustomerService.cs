﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopREG.Entities;

namespace CoffeeShopREG.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
