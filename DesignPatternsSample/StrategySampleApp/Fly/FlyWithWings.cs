using System;

namespace StrategySampleApp.Fly
{
    public class FlyWithWings: IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with my wings.");
        }
    }
}
