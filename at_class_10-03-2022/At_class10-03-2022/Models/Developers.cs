using System;
using System.Collections.Generic;
using System.Text;

namespace Book_buying.Models
{
    internal class Developers:Person
    {
        //fields

        public double salary;

        //public Developers()
        //{
        //    Console.WriteLine("TEST TEST TEST");
        //}
        //public Developers(string name) : this()
        //{
        //    this.name = name;

        //}
        //public Developers(string name, string surname, int age) : this(name)
        //{
        //    this.surname = surname;
        //    this.age = age;
        //}

        public Developers()
        {
            Console.WriteLine("Developersdeki constructora hec ne elave edilmeyib");
        }
        public Developers(string name, string surname): base(name , surname)
        {
            
        }
    }
}
