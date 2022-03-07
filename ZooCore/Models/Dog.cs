using System;
using System.Collections.Generic;
using System.Text;

namespace ZooCore.Models
{
    public class Dog : Animal
    {
        public string Breed { get; set; }
        public string ChipId { get; set; }
        
        //base is refering to the parent class Animal and calling its constructor
        public Dog(string name, string birthDate, string chipId) : base(name, birthDate)
        {
            ChipId = chipId;
        }
        public Dog(string name, string birthDate, string chipId, string breed) : this(name, birthDate, chipId)
        {
            Breed = breed;
        }

    }
}
