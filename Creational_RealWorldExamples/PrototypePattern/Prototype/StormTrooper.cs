using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern.Prototype
{
    public abstract class StormTrooper:ICloneable
    {
        public int FirePower { get; set; }
        public int Armor { get; set; }
        
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
