using System;
using shopping.Models;

namespace shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book kitab1 = new Book("1984","George Orwell",230,20,10);
            kitab1.Getinfo();

            Console.WriteLine($"Discount price: {kitab1.GetDiscountPrice(20,10)}$");

        }
    }
}
