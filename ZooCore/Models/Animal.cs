using System;

namespace ZooCore.Models
{
    public abstract class Animal
    {
        private readonly int id;

        public int Id { get { return id; } }
        public string Name { get; set; }
        public string Breed { get; set; }
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

        public Animal(int id)
        {
            this.id = id;
            IsAlive = true;
        }
        public Animal(int id, string name) : this(id)
        {
            Name = name;
        }
        public Animal(int id, string name, string birthDate) : this(id, name)
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
            return $"Age: {age.Year - 1}";//computer counts year zero, people tend to not so minus 1 year to counter the diffreance.
        }

        public abstract string Info();

        public override string ToString()
        {
            return $"Animal {id}: {Name} - Birth: {Birth.ToShortDateString()} - {Age()}";
        }
    }
}
