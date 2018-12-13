using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace lab1
{
    public static class ProductUtil
    {
        private const string UpcPattern = "^[0-9]{12}$";
        private static readonly Regex UpcRegex = new Regex(UpcPattern);

        public static bool IsValidUpc(string upc) {
            return !string.IsNullOrEmpty(upc) && UpcRegex.IsMatch(upc);
        }
        
        public static List<Product> FindProductsByName(Product[] products, string name) {
            var productsList = new List<Product>();
            if (IsProductArrayValid(products) && !string.IsNullOrEmpty(name)) {
                foreach (var product in products) {
                    if (AreStringsEqualIgnoreCase(product.Name, name)) {
                        productsList.Add(product);
                    }
                }
            } else {
                Console.Write("Invalid params");
            }
            return productsList;
        }

        public static List<Product> FindProductsByNameAndBelowProvidedPrice(Product[] products, string name,
            double price) {
            var productsList = new List<Product>();
            
            if (IsProductArrayValid(products) && !string.IsNullOrEmpty(name)) {
                foreach (var product in products) {
                    if (AreStringsEqualIgnoreCase(product.Name, name) && product.Price < price) {
                        productsList.Add(product);
                    }
                }
            } else {
                Console.Write("Invalid params");
            }
            return productsList;
        }
        
        public static List<Product> FindProductsStoredMoreThanProvidedPeriod(Product[] products, int shelfLifeMonth) {
            var productsList = new List<Product>();
            if (IsProductArrayValid(products)) {
                foreach (var product in products) {
                    if (product.ShelfLifeMonth > shelfLifeMonth) {
                        productsList.Add(product);
                    }
                }
            } else {
                Console.Write("Invalid params");
            }
            return productsList;
        }

        private static bool AreStringsEqualIgnoreCase(string firstString, string secondString) {
            return firstString.Equals(secondString, StringComparison.InvariantCultureIgnoreCase);
        }

        private static bool IsProductArrayValid(Product[] products) {
            return products != null && products.Any();
        }
    }
}