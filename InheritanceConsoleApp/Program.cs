using System;
using ZooCore.Models;

namespace InheritanceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Pluto", "2010-01-12", "234ASDY");

            Console.WriteLine(dog);
            Console.WriteLine(dog.Age());
        }
    }
}
