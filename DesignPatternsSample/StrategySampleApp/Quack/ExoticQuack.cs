using System;

namespace StrategySampleApp.Quack
{
    public class ExoticQuack:IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quaaaaaack-Quaaaaaack");
        }
    }
}
