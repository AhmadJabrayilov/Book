using System;
using System.Collections.Generic;
using System.Text;

namespace shopping.Models
{
    internal class Book:Product
    {
        // fields for Book
        public string authorName;
        public int pageCount;
        public int discountPercent;

        public Book (string name, string authorName, int pageCount, int saledPrice, int discountPercent):base(name,saledPrice)
        {
           this.authorName = authorName;
           this.pageCount = pageCount;
           this.discountPercent = discountPercent;

        }

       
       
        public void Getinfo()
        {
            Console.WriteLine($"Book name: {name}\nAuthor: {authorName}\nPage count: {pageCount} Pages\nPrice: {saledPrice}$\nDiscount percent: {discountPercent}%");

        }

        public int GetDiscountPrice(int saledPrice, int discountPersent)
        {
            int discountPrice = saledPrice - ((saledPrice * discountPersent)/100);
            return discountPrice;
        }


    }







}
