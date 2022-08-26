using StarbucksNeroCustomerRegister.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MernisServisReference;

namespace StarbucksNeroCustomerRegister.Abstract
{
    public interface ICustomerCheckService
    { 
        Task<TCKimlikNoDogrulaResponse> CheckIfRealPerson(Customer customer);
    }
}
