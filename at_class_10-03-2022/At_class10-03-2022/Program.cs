using System;
using Book_buying.Models;


namespace Book_buying
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //insatance 

            //Student student1 = new Student("Ahmed","Jabrayilov",24);
            //student1.name = "Ahmed";
            //student1.surname = "Jabrayilov";
            //student1.age = 24;


            //student1.FullName();
            //Console.WriteLine(student1.GetAge());

            //Student student2 = new Student("Kermit");
            //student2.name = "Kermit";
            //student2.surname = "The Frog";
            //student2.age = 21;

            //student2.FullName();
            //Console.WriteLine(student2.GetAge());

            //Student student3 = new Student("Kermit","The Frog");
            //student3.age = 25;
            //student3.FullName();
            //Console.WriteLine(student3.GetAge());
             

            Developers dev1 = new Developers("Ahmed","Jabrayilov ");
            //dev1.age = 23;
            dev1.FullName();
            //Console.WriteLine(dev1.GetAge());
        }
    }

    
}
