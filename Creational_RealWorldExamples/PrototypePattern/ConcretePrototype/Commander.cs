using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrototypePattern.Prototype;

namespace PrototypePattern.ConcretePrototype
{
    public class Commander:StormTrooper
    {
        public Commander()
        {
            Armor = 15;
            FirePower = 20;
        }
    }
}
