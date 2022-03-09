using System;
using System.Collections.Generic;
using System.Text;

namespace ZooCore.Models
{
    class ChainSaw : Tool, IDanger
    {

        public ChainSaw()
        {
        }

        public int DangerLevel()
        {
            return 6;
        }

        public string SaftyInstructions()
        {
            return "Have training and correct safty close before operating the chainsaw";
        }
    }
}
