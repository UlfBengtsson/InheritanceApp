using System;

namespace ZooCore.Models
{
    public class Animal
    {
        public string Name { get; set; }

        public DateTime Birth { get; set; }

        private DateTime death;
        public DateTime Death
        {
            get { return death; }
            set
            {
                IsAlive = false;
                death = value;
            } 
        }

        public bool IsAlive { get; private set; }

        public Animal()
        {
            IsAlive = true;
        }
        public Animal(string name) : this()
        {
            Name = name;
        }
        public Animal(string name, string birthDate) : this(name)
        {
            Birth = DateTime.Parse(birthDate);
        }

        public string Age()
        {
            DateTime age = new DateTime(
                (
                    (IsAlive ? DateTime.Now : Death)
                                                     - Birth).Ticks
                );
            return $"Age: {age.Year}";
        }

        public override string ToString()
        {
            return $"Animal: {Name} - Birth: {Birth.ToShortDateString()} - {Age()}";
        }
    }
}
