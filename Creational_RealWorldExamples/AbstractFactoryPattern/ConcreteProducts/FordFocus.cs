using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryPattern.AbstractProduct;

namespace AbstractFactoryPattern.ConcreteProducts
{
    public class FordFocus : Vehicle
    {
        public FordFocus()
        {
            Model = "Ford Focus";
            Engine = "1.0 L EcoBoost I3";
            Transmission = "6-speed PowerShift automatic";
            Body = "5-door hatchback";
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
