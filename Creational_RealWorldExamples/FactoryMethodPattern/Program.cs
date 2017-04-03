using System.Reflection;
using FactoryMethodPattern.FactoryBase;
using FactoryMethodPattern.ProductBase;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory factory = GetFactory("FactoryMethodPattern.ConcreteFactories.LincolnAviatorFactory");

            var lincolnAviator = factory.CreateVehicle();

            lincolnAviator.ShowInfo();

            factory = GetFactory("FactoryMethodPattern.ConcreteFactories.FordExplorerFactory");

            var fordExplorer = factory.CreateVehicle();

            fordExplorer.ShowInfo();
        }

        static IVehicleFactory GetFactory(string factoryName)
        {
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IVehicleFactory;
        }
    }
}
