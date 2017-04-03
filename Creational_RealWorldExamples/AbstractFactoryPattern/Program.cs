using System;
using System.Collections.Generic;
using System.Reflection;
using AbstractFactoryPattern.AbstractFactory;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main()
        {
            foreach (var factoryy in GetFactories())
            {
                factoryy.CreateEconomyCar().ShowInfo();
                factoryy.CreateRacingCar().ShowInfo();
                factoryy.CreateSUV().ShowInfo();
                Console.WriteLine();
            }
        }

        static IEnumerable<IVehicleFactory> GetFactories()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in types)
            {
                if (type.GetInterface(typeof(IVehicleFactory).ToString()) != null)
                {                    
                    yield return Activator.CreateInstance(type) as IVehicleFactory;
                }
            }
        }
    }
}
