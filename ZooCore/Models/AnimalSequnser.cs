using System;
using System.Collections.Generic;
using System.Text;

namespace ZooCore.Models
{
    public class AnimalSequnser
    {
        private static int idCounter = 0;

        public static int NextAnimalId()
        {
            return ++idCounter;
        }

        public static void Clear()
        {
            idCounter = 0;
        }
    }
}
