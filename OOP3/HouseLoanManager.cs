using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class HouseLoanManager : ICreditManager

    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme olanı hesaplandı!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
