using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class Products {
        public string Name { get; set; }
        public double Price { get; set; }

        public Products(string name, double price) {
            Name = Name;
            Price = Price;
        }

        public override string ToString() {
            return Name + ", " + Price.ToString("F2");
        }
    }
}
