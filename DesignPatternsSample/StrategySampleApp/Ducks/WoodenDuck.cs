using System;
using StrategySampleApp.Fly;
using StrategySampleApp.Quack;

namespace StrategySampleApp.Ducks
{
    class WoodenDuck : DuckBase
    {
        public WoodenDuck()
        {
            flyBehaviour = new NoFLy();
            quackBehaviour = new NoQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a wooden duck.");
        }
    }
}
