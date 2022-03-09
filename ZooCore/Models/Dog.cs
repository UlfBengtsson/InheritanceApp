using System;
using System.Collections.Generic;
using System.Text;

namespace ZooCore.Models
{
    //Inheritance form 1 class only, but can have many Interfaces.
    public class Dog : Animal, IDanger
    {
        private int dangerLevel;
        public string ChipId { get; set; }
        
        //base is refering to the parent class Animal and calling its constructor
        public Dog(int id, string name, string birthDate, string chipId) : base(id, name, birthDate)
        {
            ChipId = chipId;
            dangerLevel = 3;
        }

        public Dog(int id, string name, string birthDate, string chipId, int dangerLevel) : this(id, name, birthDate, chipId)
        {
            this.dangerLevel = dangerLevel;
        }

        public override string Info()
        {
            return $"-- Dog --\nBreed: {Breed}\nName: {Name}\nChip: {ChipId}\n";
        }

        public int DangerLevel()
        {
            return dangerLevel;
        }

        public string SaftyInstructions()
        {
            throw new NotImplementedException();
        }
    }
}
