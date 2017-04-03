using System;

namespace StrategySampleApp.Ducks
{
    class SimpleDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("Hi! I'm a simple duck.");
        }
    }
}
