using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titkov_Andrii_2419050_Assignment_3
{
    internal class Product
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public Product(string type, string color, double price)
        {
            Type = type;
            Color = color;
            Price = price;
        }
    }
}
