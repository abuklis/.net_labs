using System;

namespace lab1
{
    internal class Runner
    {
        public static void Main(string[] args)
        {
            var product1  = new Product(1, "Phone", "123456789123", "Samsung", 200, 14, 20);
            var product2  = new Product(2, "TV", "123456789127", "Apple",300 , 17, 13);
            var product3  = new Product(3, "Xerox", "123456789123", "HP", 400, 19, 2);
            
            var products = new Product[3];
            products[0] = product1;
            products[1] = product2;
            products[2] = product3;


            Console.WriteLine("--All TVs:");
            ProductUtil.FindProductsByName(products, "TV").ForEach(Console.WriteLine);
            
            Console.WriteLine("--Phones with price below 300:");
            ProductUtil.FindProductsByNameAndBelowProvidedPrice(products, "Phone", 300).ForEach(Console.WriteLine);
            
            
            Console.WriteLine("--Products which lies on the shelf more than 17 months");
            ProductUtil.FindProductsStoredMoreThanProvidedPeriod(products, 16).ForEach(Console.WriteLine);
        }
    }
}