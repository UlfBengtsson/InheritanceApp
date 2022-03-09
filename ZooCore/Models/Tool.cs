using System;
using System.Collections.Generic;
using System.Text;

namespace ZooCore.Models
{
    public class Tool
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public DateTime LastService { get; set; }

    }
}
