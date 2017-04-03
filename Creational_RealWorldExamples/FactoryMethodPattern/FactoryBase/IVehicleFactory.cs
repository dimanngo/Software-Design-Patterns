using FactoryMethodPattern.ProductBase;

namespace FactoryMethodPattern.FactoryBase
{
    public interface IVehicleFactory
    {
        Vehicle CreateVehicle();
    }
}
