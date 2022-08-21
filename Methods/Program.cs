using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Def = "Its just a apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 47;
            product2.Def = "Casual watermelon";

            Product[] products = new Product[] { product1, product2 };
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Def);
                Console.WriteLine("----------------------------");
            } 
            Console.WriteLine("-----------------------Methods-----------------------");
            //instance - örnek
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);

            // bunu kullanma
            basketManager.Add2("Armut","Yeşil Armur",12,10);
            basketManager.Add2("Elma","Yeşil Elma",12,9);
            basketManager.Add2("Karpuz","Diyarbakır Karpuzu",12,8);
        }
    }
}
