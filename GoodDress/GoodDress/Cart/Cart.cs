using System;
using System.Collections.Generic;
using System.Text;

namespace GoodDress.Cart
{
    class Cart
    {
        private List<CartElement> CartElements = new List<CartElement>();

        public void Add(Products Product, int Amount) // сделать делигаты и события
        {
            CartElements.Add(new CartElement(Product, Amount)); 
        }

    }
}
