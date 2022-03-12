using System;
using System.Collections.Generic;
using System.Text;

namespace shopping.Models
{
    internal class Product
    {
        //fields
        public string name;
        public int costPrice; //Maya deyeri
        public int saledPrice; // Satish deyeri

        public Product(string name, int saledPrice)
        {
            this.name = name;
            this.saledPrice = saledPrice;
        }

        public Product()
        {

        }


    }
}
