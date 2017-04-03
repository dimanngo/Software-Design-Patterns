using System;
using StrategySampleApp.Fly;

namespace StrategySampleApp.Ducks
{
    class RubberDuck: DuckBase
    {
        public RubberDuck()
        {
            flyBehaviour = new NoFLy();
        }
        public override void Display()
        {
            Console.WriteLine("Hi! I'm a rubble duck.");
        }
    }
}
