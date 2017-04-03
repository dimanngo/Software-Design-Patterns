using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.AbstractProduct;
using AbstractFactoryPattern.ConcreteProducts;

namespace AbstractFactoryPattern.ConcreteFactories
{
    public class MitsubishiFactory:IVehicleFactory
    {
        public Vehicle CreateEconomyCar()
        {
            return new MitsubishiI();
        }

        public Vehicle CreateRacingCar()
        {
            return new MitsubishiLancerEvoIX();
        }

        public Vehicle CreateSUV()
        {
            return new MitsubishiPajero();
        }
    }
}
