using System;
using System.Collections.Generic;
using ZooCore.Models;
using ZooCore.Utilitys;

namespace InheritanceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Pluto", "2010-01-12", "234ASDY");

            //Console.WriteLine(dog);
            //Console.WriteLine(dog.Age());

            Bird segual = new Bird("Boye", "2020-05-21", 42.2, true);

            //Console.WriteLine(segual);

            List<Animal> animals = new List<Animal>() { dog, segual };

            foreach (Animal item in animals)
            {
                Console.WriteLine(item);
            }

            foreach (Bird item in ZooUtil.FilterToOnlyBirds(animals))
            {
                Console.WriteLine(item);
            }
        }


    }
}
