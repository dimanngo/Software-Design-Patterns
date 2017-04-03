using System;
using System.Collections.Generic;
using StrategySampleApp.Ducks;
using StrategySampleApp.Fly;
using StrategySampleApp.Quack;

namespace StrategySampleApp
{
    class Program
    {
        static void Main()
        {
            var ducks = new List<DuckBase>
            {
                new SimpleDuck(),
                new ExoticDuck(),
                new WoodenDuck(),
                new RubberDuck()
            };

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
                duck.Fly();

                Console.WriteLine();
            }

            var upgradableDuck = new UpgradableDuck();
            upgradableDuck.Display();
            upgradableDuck.Swim();

            upgradableDuck.flyBehaviour = new FlyWithWings();
            upgradableDuck.quackBehaviour = new ExoticQuack();
            upgradableDuck.Quack();
            upgradableDuck.Fly();
        }
    }
}
