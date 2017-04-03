using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryPattern.AbstractProduct;

namespace AbstractFactoryPattern.ConcreteProducts
{
    class MitsubishiLancerEvoIX:Vehicle
    {
        public MitsubishiLancerEvoIX()
        {
            Model = "Mitsubishi Lancer Evo IX";
            Engine = "4B10 1.8 L DOHC I4";
            Transmission = "6-speed twin-clutch transmission";
            Body = "4-door sedar";
            Doors = 4;
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
