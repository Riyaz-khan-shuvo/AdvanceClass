using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceClass
{
    class Animal 
    { 
        string name ;
        int age ;
        string voice;
        public static int numberOfAnimal = 0;
        public void PrintDetails()
        {
            Console.WriteLine("Your Pet name is : " + name + " Age is : " + age + " Voice is : " + voice);
            Console.WriteLine();
        }
        public Animal(string _name , int _age , string _voice)
        {
            name = _name ;
            age = _age ;
            voice = _voice ;
            numberOfAnimal++;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal("Dog" , 7 , "Gaw Gaw");
            dog.PrintDetails();

            Animal cat = new Animal("Cat", 9, "Mew mew");
            cat.PrintDetails();

            Console.WriteLine(dog.ToString());

            Console.WriteLine("Total Animal : " + Animal.numberOfAnimal);

            // number of animal is statice value so we can access this directly we have not to create the object in static method


            Console.ReadLine();
        }
    }
}
