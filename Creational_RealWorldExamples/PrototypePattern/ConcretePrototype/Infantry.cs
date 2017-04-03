using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrototypePattern.Prototype;

namespace PrototypePattern.ConcretePrototype
{
    public class Infantry : StormTrooper
    {
        public Infantry()
        {
            FirePower = 10;
            Armor = 9;
        }
    }
}
