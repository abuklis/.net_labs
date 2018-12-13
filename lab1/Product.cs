using System;

namespace lab1
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        private string _upc;
        public string Upc { 
            get { return _upc; }
            set { 
               if (ProductUtil.IsValidUpc(value)) {
                   _upc = value;
               } else {
                  throw new ArgumentException("UPC code should have 12 digits. Wrong UPC" + value);
              }
            } 
        }
        public string Manufacturer { get; set;  }
        public double Price { get; set; }
        public int ShelfLifeMonth{ get; set; }
        public int Quantity{ get; set; }


        public Product(long id, string name, string upc, string manufacturer, double price, 
            int shelfLifeMonth, int quantity) {
            Id = id;
            Name = name;
            Upc = upc;
            Manufacturer = manufacturer;
            Price = price;
            ShelfLifeMonth = shelfLifeMonth;
            Quantity = quantity;
        }

        public override string ToString() {
            return "Product: " + Name + ", " +
                   Upc + ", " + Manufacturer + ", " +
                   Price + ", " + ShelfLifeMonth + ", " +
                   Quantity;
        }
    }
}