using System;
using System.Collections.Generic;
using System.Text;

namespace ZooCore.Models
{
    public class Bird : Animal
    {
        public double WingSpan { get; set; }
        public bool CanFly { get; set; }
        public Bird(string name, string birthDate, double wingSpan, bool canFly) : base(name, birthDate)
        {
            WingSpan = wingSpan;
            CanFly = canFly;
        }
    }
}
