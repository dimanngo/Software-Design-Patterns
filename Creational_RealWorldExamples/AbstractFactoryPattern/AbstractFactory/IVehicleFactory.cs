using AbstractFactoryPattern.AbstractProduct;

namespace AbstractFactoryPattern.AbstractFactory
{
    public interface IVehicleFactory
    {
        Vehicle CreateEconomyCar();
        Vehicle CreateRacingCar();
        Vehicle CreateSUV();
    }
}
