using System;
using System.Collections.Generic;
using System.Text;
using ZooCore.Models;

namespace ZooCore.Utilitys
{
    public class ZooUtil
    {
        public static List<Dog> FilterToOnlyDogs(List<Animal> animals)
        {
            List<Dog> dogs = new List<Dog>();

            foreach (Animal animal in animals)
            {
                if (animal is Dog)
                {
                    dogs.Add(animal as Dog);
                }
            }

            return dogs;
        }

        public static List<Bird> FilterToOnlyBirds(List<Animal> animals)
        {
            List<Bird> birds = new List<Bird>();

            foreach (Animal animal in animals)
            {
                if (animal is Bird)
                {
                    birds.Add(animal as Bird);
                }
            }

            return birds;
        }

        public static List<IDanger> FilterToOnlyDangerus(List<Animal> animals)
        {
            List<IDanger> dangerus = new List<IDanger>();

            foreach (Animal animal in animals)
            {
                if (animal is IDanger)
                {
                    dangerus.Add(animal as IDanger);
                }
            }

            return dangerus;
        }

        public static List<IDanger> FilterToOnlyDangerus(List<Tool> tools)
        {
            List<IDanger> dangerus = new List<IDanger>();

            foreach (Tool tool in tools)
            {
                if (tool is IDanger)
                {
                    dangerus.Add(tool as IDanger);
                }
            }

            return dangerus;
        }

        public static List<IDanger> FilterToOnlyDangerus(List<Tool> tools, List<Animal> animals)
        {
            List<IDanger> dangerus = new List<IDanger>();

            dangerus.AddRange(FilterToOnlyDangerus(tools));
            dangerus.AddRange(FilterToOnlyDangerus(animals));

            return dangerus;
        }
    }
}
