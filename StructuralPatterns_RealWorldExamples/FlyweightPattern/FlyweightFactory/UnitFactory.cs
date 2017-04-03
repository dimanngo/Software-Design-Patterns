using System;
using System.Collections.Generic;
using FlyweightPattern.ConcreteFlyweights;
using FlyweightPattern.FlyweightBase;

namespace FlyweightPattern.FlyweightFactory
{
    public class UnitFactory
    {
        private readonly Dictionary<string, Unit> _units = new Dictionary<string, Unit>();

        public Unit GetUnit(string type)
        {
            if (_units.ContainsKey(type))
            {
                return _units[type];
            }
            Unit unit;

            switch (type)
            {
                case "Infantry":
                    unit = new Soldier
                               {
                                   Name = "Standard Infantry",
                                   Armour = 5,
                                   Speed = 4,
                                   RotationRate = 180,
                                   FireRate = 5,
                                   Range = 100,
                                   FirePower = 5
                               };
                    break;

                case "Marine":
                    unit = new Soldier
                               {
                                   Name = "Marine",
                                   Armour = 25,
                                   Speed = 4,
                                   RotationRate = 180,
                                   FireRate = 3,
                                   Range = 200,
                                   FirePower = 10
                               };
                    break;

                case "Tank":
                    unit = new Tank
                               {
                                   Name = "Tank",
                                   Armour = 1000,
                                   Speed = 25,
                                   RotationRate = 5,
                                   FireRate = 30,
                                   Range = 1000,
                                   FirePower = 250
                               };
                    break;

                default:
                    throw new ArgumentException();
            }

            _units.Add(type, unit);
            return unit;
        }
    }
}
