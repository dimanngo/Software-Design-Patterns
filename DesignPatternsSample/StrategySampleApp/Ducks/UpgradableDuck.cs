using System;
using StrategySampleApp.Fly;
using StrategySampleApp.Quack;

namespace StrategySampleApp.Ducks
{
    class UpgradableDuck: DuckBase
    {
        public UpgradableDuck()
        {
            flyBehaviour = new NoFLy();
            quackBehaviour = new NoQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm an upgradable duck.");
        }
    }
}
