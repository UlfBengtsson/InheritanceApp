using System;
using System.Collections.Generic;
using System.Text;
using ZooCore.Models;

namespace ZooCore.Services
{
    public class AnimalService : ICrud<Animal>
    {
        private static List<Animal> storage = new List<Animal>();

        public Animal CreateAndSave(Animal data)
        {
            Animal animal = null;
            if (data is Dog)
            {
                animal = new Dog(
                    AnimalSequnser.NextAnimalId(),
                    data.Name,
                    data.Birth.ToShortDateString(),
                    (data as Dog).ChipId,
                    (data as Dog).DangerLevel()
                    );
            }
            else if (data is Bird)
            {
                animal = new Bird(
                    AnimalSequnser.NextAnimalId(),
                    data.Name,
                    data.Birth.ToShortDateString(),
                    (data as Bird).WingSpan,
                    (data as Bird).CanFly
                    );
            }

            storage.Add(animal);

            return animal;
        }

        public List<Animal> FindAll()
        {
            return storage;
        }

        public Animal FindById(int id)
        {
            foreach (Animal animal in storage)
            {
                if (animal.Id.Equals(id))
                {
                    return animal;
                }
            }
            return null;
        }

        public bool Update(Animal data)
        {
            for (int i = 0; i < storage.Count; i++)
            {
                if (storage[i].Id.Equals(data.Id))
                {
                    storage[i] = data;
                    return true;
                }
            }
            return false;
        }
        public bool Delete(int id)
        {
            return storage.Remove(FindById(id));
        }
    }
}
