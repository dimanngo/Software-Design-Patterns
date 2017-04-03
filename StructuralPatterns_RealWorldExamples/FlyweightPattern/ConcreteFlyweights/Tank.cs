using System;
using FlyweightPattern.FlyweightBase;

namespace FlyweightPattern.ConcreteFlyweights
{
    public class Tank:Unit
    {
        public static int NumberOfInstances;

        public Tank()
        {
            NumberOfInstances++;
        }

        public override void FireAt(Target target)
        {
            Console.WriteLine("Firing at {0} with power of {1}.", target.ID, FirePower);
        }
    }
}
