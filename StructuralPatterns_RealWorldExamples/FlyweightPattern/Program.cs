using System;
using System.Collections.Generic;
using System.Linq;
using FlyweightPattern.ConcreteFlyweights;
using FlyweightPattern.FlyweightFactory;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitFactory factory = new UnitFactory();

            Target tank1 = new Target();
            tank1.ID = Guid.NewGuid();
            tank1.UnitData = factory.GetUnit("Tank");

            Target tank2 = new Target();
            tank2.ID = Guid.NewGuid();
            tank2.UnitData = factory.GetUnit("Tank");

            bool result = tank1.UnitData == tank2.UnitData;     // result = true
            int firepower = tank1.UnitData.FirePower;    

            Console.WriteLine("Tank Instances: "+ Tank.NumberOfInstances);

            Target soldier1 = new Target();
            soldier1.ID = Guid.NewGuid();
            soldier1.UnitData = factory.GetUnit("Marine");

            var soldier2 = new Target();
            soldier2.UnitData = factory.GetUnit("Infantry");
            soldier2.ID = Guid.NewGuid();

            var soldier3 = new Target();
            soldier3.UnitData = factory.GetUnit("Infantry");
            soldier3.ID = Guid.NewGuid();

            Console.WriteLine("Soldier Instances: " + Soldier.NumberOfInstances);
        }
    }
}
