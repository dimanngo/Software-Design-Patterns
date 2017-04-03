using System;
using StrategySampleApp.Fly;
using StrategySampleApp.Quack;

namespace StrategySampleApp.Ducks
{
    public abstract class DuckBase
    {
        public IFlyable flyBehaviour { get; set; }
        public IQuackable quackBehaviour { get; set; }

        protected DuckBase()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new SimpleQuack();
        }

        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("I'm swimming.");
        }

        public void Quack()
        {
            quackBehaviour.Quack();
        }

        public void Fly()
        {
            flyBehaviour.Fly();
        }
    }
}
