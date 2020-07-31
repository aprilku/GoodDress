using System;
using System.Collections.Generic;
using System.Text;

namespace GoodDress.Cart
{
    public class CartElement
    {
        public Products Product { get; set; }
        public int Amount { get; set; }

        public CartElement(Products Product, int Amount)
        {
            this.Product = Product;
            this.Amount = Amount;
        }
    }
}
