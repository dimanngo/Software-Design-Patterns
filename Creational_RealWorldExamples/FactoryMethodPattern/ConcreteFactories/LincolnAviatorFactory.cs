using FactoryMethodPattern.ConcreteProducts;
using FactoryMethodPattern.FactoryBase;
using FactoryMethodPattern.ProductBase;

namespace FactoryMethodPattern.ConcreteFactories
{
    public class LincolnAviatorFactory:IVehicleFactory
    {
        public Vehicle CreateVehicle()
        {
            return new LincolnAviator("Lincoln Aviator","4.6 L DOHC Modular V8","5-speed automatic","SUV",4);
        }
    }
}
