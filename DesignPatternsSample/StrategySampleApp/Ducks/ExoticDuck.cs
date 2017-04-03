using System;
using StrategySampleApp.Quack;

namespace StrategySampleApp.Ducks
{
    class ExoticDuck: DuckBase
    {
        public ExoticDuck()
        {
            quackBehaviour = new ExoticQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Hi! I'm an exotic duck.");
        }
    }
}
