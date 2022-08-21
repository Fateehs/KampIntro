using System;

namespace TrendYolListRecap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ürünlerin olduğu kısım
            Product productid1 = new Product();
            productid1.ProductType = "T-Shirt";
            productid1.ProductBrand = "Zokawear";
            productid1.ProductName = "Unisex Beyaz T-Shirt";
            productid1.ProductSize = "S";
            productid1.ProductPrice = 44.32;
            productid1.ProductStock = true;

            Product productid2 = new Product();
            productid2.ProductType = "T-Shirt";
            productid2.ProductBrand = "MOSST";
            productid2.ProductName = "Nakis Detayli Iki Iplik T-shirt";
            productid2.ProductSize = "S";
            productid2.ProductPrice = 101.19;
            productid2.ProductStock = true;

            Product productid3 = new Product();
            productid3.ProductType = "T-Shirt";
            productid3.ProductBrand = "ALEXANDER SWOOSH";
            productid3.ProductName = "Oversize T-shirt Orange Trajan";
            productid3.ProductSize = "S";
            productid3.ProductPrice = 200;
            productid3.ProductStock = true;

            Product productid4 = new Product();
            productid4.ProductType = "T-Shirt";
            productid4.ProductBrand = "ALEXANDER SWOOSH";
            productid4.ProductName = "Oversize T-shirt Pink Yakuza";
            productid4.ProductSize = "M";
            productid4.ProductPrice = 200;
            productid4.ProductStock = true;

            Product productid5 = new Product();
            productid5.ProductType = "T-Shirt";
            productid5.ProductBrand = "Jooy Company";
            productid5.ProductName = "Siyah Beyaz Oval Kesim Gül Tasarim Tshirt 2'li Set";
            productid5.ProductSize = "L";
            productid5.ProductPrice = 149.90;
            productid5.ProductStock = true;

            Product[] products = new Product[] { productid1, productid2, productid3, productid4, productid5 };
            // ürünleri gezen döngü
            foreach (var product in products)
            {
                Console.WriteLine(" Ürünün Tipi : " + product.ProductType +
                                  " Ürünün Markası : " + product.ProductBrand +
                                  " Ürünün Adı : " + product.ProductName +
                                  " Ürünün Bedeni : " + product.ProductSize +
                                  " Ürünün Fiyatı : " + product.ProductPrice +
                                  " Ürünün Stock Durumu : " + product.ProductStock);
            }
            Console.ReadLine();
        }
    }
    // ürünlerin datasını alan kısım
    class Product
    {
        public string ProductType { get; set; }
        public string ProductBrand { get; set; }
        public string ProductName { get; set; }
        public string ProductSize { get; set; }
        public double ProductPrice { get; set; }
        public bool ProductStock { get; set; }

    }
}
