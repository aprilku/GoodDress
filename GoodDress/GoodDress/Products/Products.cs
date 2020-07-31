using System;
using System.Collections.Generic;
using System.Text;

namespace GoodDress
{
    public abstract class Products
    {
        public string Id { get; set; }

        public string Name { get; set; } // Name of Product

        public double Price { get; set; } // Price of Product

        public override string ToString()
        {
            return $"Name: {Name} Price: {Price}";
        }

    }
}
