using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.AbstractProduct;
using AbstractFactoryPattern.ConcreteProducts;

namespace AbstractFactoryPattern.ConcreteFactories
{
    class FordFactory:IVehicleFactory
    {
        public Vehicle CreateEconomyCar()
        {
            return new FordFocus();
        }

        public Vehicle CreateRacingCar()
        {
            return new FordGT1();
        }

        public Vehicle CreateSUV()
        {
            return new FordExplorer();
        }
    }
}
