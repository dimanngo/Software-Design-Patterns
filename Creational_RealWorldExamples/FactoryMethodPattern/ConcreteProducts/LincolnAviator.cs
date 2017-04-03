using System;
using FactoryMethodPattern.ProductBase;

namespace FactoryMethodPattern.ConcreteProducts
{
    public class LincolnAviator:Vehicle
    {
        public LincolnAviator(string model, string engine, string transmission, string body, int doors)
        {
            Model = model;
            Engine = engine;
            Transmission = transmission;
            Body = body;
            Doors = doors;
            Accessories.Add("Leather Look Seat Covers");
            Accessories.Add("Chequered Plate Racing Floor");
            Accessories.Add("4x 200 Watt Coaxial Speekers");
            Accessories.Add("500 Watt Bass Subwoofer");
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
