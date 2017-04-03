using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorators
{
    public class Corn : SandwichDecorator
    {
        public Corn(Sandwich sandwich)
            : base(sandwich)
        {
            Description = "Corn";
        }

        public override string GetDescription()
        {
            return Sandwich.GetDescription()+", "+Description;
        }

        public override double GetPrize()
        {
            return Sandwich.GetPrize()+ 0.35;
        }
    }
}
