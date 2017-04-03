using System;
using FactoryMethodPattern.ProductBase;

namespace FactoryMethodPattern.ConcreteProducts
{
    public class FordExplorer:Vehicle
    {

        public FordExplorer()
        {
            Model = "Ford Explorer";
            Engine = "4.0 L Cologne V6";
            Transmission = "5-speed M50D-R1 manual";
            Body = "SUV";
            Doors = 5;
            Accessories.Add("Car Cover");
            Accessories.Add("Sun Shade");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Engine: {0}", Engine);
            Console.WriteLine("Body: {0}", Body);
            Console.WriteLine("Doors: {0}", Doors);
            Console.WriteLine("Transmission: {0}", Transmission);
            Console.WriteLine("Accessories:");
            foreach (var accessory in Accessories)
            {
                Console.WriteLine("\t{0}", accessory);
            }
        }
    }
}
