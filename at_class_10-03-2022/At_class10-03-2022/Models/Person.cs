using System;
using System.Collections.Generic;
using System.Text;

namespace Book_buying.Models
{
    internal class Person
    {
        //fields
        public string name;
        public string surName;
        public int age;

        public Person(string name, string surName)
        {
            this.name = name;
            this.surName = surName;

        }

        public Person()
        {

        }

        //public Person()
        //{
        //    Console.WriteLine("TEST TEST TEST");
        //}
        //public Person(string name) : this()
        //{
        //    this.name = name;

        //}
        //public Person(string name, string surname, int age) : this(name)
        //{
        //    this.surname = surname;
        //    this.age = age;
        //}


        public void FullName()
        {
            Console.WriteLine($"{name} {surName}");
        }


        public int GetAge()
        {
            return age;
        }
    }
}
