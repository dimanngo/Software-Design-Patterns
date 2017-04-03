using FactoryMethodPattern.ConcreteProducts;
using FactoryMethodPattern.FactoryBase;
using FactoryMethodPattern.ProductBase;

namespace FactoryMethodPattern.ConcreteFactories
{
    public class FordExplorerFactory:IVehicleFactory
    {
        public Vehicle CreateVehicle()
        {
            return new FordExplorer();
        }
    }
}
