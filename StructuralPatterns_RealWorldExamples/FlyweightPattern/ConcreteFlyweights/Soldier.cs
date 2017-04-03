using System;
using FlyweightPattern.FlyweightBase;

namespace FlyweightPattern.ConcreteFlyweights
{
    public class Soldier:Unit
    {
        public static int NumberOfInstances;

        public Soldier()
        {
            NumberOfInstances++;
        }

        public override void FireAt(Target target)
        {
            Console.WriteLine("Shooting at unit {0} with power of {1}."
                , target.ID, FirePower);
        }
    }
}
