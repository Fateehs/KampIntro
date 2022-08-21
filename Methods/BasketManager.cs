using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
     class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler " + product.Name + " sepete eklendi! : ");
        }

        public void Add2(string productName, string productDef, double productPrice, int productStock)
        {
            Console.WriteLine("Tebrikler " + productName + " sepete eklendi! : ");
        }
    }
}
