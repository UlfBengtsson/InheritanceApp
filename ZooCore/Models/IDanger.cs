using System;
using System.Collections.Generic;
using System.Text;

namespace ZooCore.Models
{
    public interface IDanger
    {
        int DangerLevel();
        string SaftyInstructions();
    }
}
