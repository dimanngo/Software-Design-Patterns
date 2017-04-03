using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryPattern.AbstractProduct;

namespace AbstractFactoryPattern.ConcreteProducts
{
    class MitsubishiPajero:Vehicle
    {
        public MitsubishiPajero()
        {
            Model = "Mitsubishi Pajero Super Exceed";
            Engine = "6G75 3.8 V6";
            Transmission = "5-speed manual";
            Body = "SUV";
            Doors = 5;
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
