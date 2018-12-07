using System;

namespace lab1
{
    public class Product
    {
        private long _id;
        private readonly string _name;
        private string _upc;
        private readonly string _manufacturer;
        private readonly double _price;
        private readonly int _shelfLifeMonth;
        private readonly int _quantity;

        public string GetName() {
            return _name;
        }
        
        public double GetPrice() {
            return _price;
        }
        
        public double GetShelfLifeMonth() {
            return _shelfLifeMonth;
        }

        public Product(long id, string name, string upc, string manufacturer, double price, 
            int shelfLifeMonth, int quantity) {
            _id = id;
            _name = name;
            SetUpc(upc);
            _manufacturer = manufacturer;
            _price = price;
            _shelfLifeMonth = shelfLifeMonth;
            _quantity = quantity;
        }

        public override string ToString() {
            return "Product: " + _name + ", " +
                   _upc + ", " + _manufacturer + ", " +
                   _price + ", " + _shelfLifeMonth + ", " +
                   _quantity;
        }

        private void SetUpc(string upc) {
            if (ProductUtil.IsValidUpc(upc)) {
                _upc = upc;
            } else {
                throw new ArgumentException("UPC code should have 12 digits. Wrong UPC" + upc);
            }
        }
    }
}