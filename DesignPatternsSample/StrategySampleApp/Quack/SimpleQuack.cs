using System;

namespace StrategySampleApp.Quack
{
    public class SimpleQuack: IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack-Quack-Quack");
        }
    }
}
