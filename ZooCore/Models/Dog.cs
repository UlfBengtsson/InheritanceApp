using System;
using System.Collections.Generic;
using System.Text;

namespace ZooCore.Models
{
    public class Dog : Animal
    {
        public string ChipId { get; set; }
        
        //base is refering to the parent class Animal and calling its constructor
        public Dog(int id, string name, string birthDate, string chipId) : base(id, name, birthDate)
        {
            ChipId = chipId;
        }

        public override string Info()
        {
            return $"-- Dog --\nBreed: {Breed}\nName: {Name}\nChip: {ChipId}\n";
        }

    }
}
