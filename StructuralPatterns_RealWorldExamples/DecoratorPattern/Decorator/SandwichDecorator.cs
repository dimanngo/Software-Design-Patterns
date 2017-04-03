using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    public class SandwichDecorator : Sandwich
    {
        protected Sandwich Sandwich;

        public SandwichDecorator(Sandwich sandwich)
        {
            Sandwich = sandwich;
        }

        public override string GetDescription()
        {
            return Sandwich.GetDescription();
        }

        public override double GetPrize()
        {
            return Sandwich.GetPrize();
        }
    }
}
