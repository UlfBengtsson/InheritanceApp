using System;
using System.Collections.Generic;
using System.Text;

namespace ZooCore.Models
{
    public class Bird : Animal
    {
        public double WingSpan { get; set; }
        public bool CanFly { get; set; }
        public Bird(int id, string name, string birthDate, double wingSpan, bool canFly) : base(id, name, birthDate)
        {
            WingSpan = wingSpan;
            CanFly = canFly;
        }

        public override string Info()
        {
            return $"-- Bird --\nName: {Name}\nWing span: {WingSpan}\n{(CanFly ? "Can fly" : "Can not fly")}\n";
        }

    }
}
