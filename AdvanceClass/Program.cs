using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceClass
{
    class Animal 
    { 
        string name = "Doggy";

        int age = 7;
        public void printDetails()
        {
            Console.WriteLine("Your Pet name is : " + name + " And Age is : " + age);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.printDetails();
            Console.ReadLine();
        }
    }
}
