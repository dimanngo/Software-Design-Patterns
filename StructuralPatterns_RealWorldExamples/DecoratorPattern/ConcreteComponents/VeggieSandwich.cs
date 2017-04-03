using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponents
{
    public class VeggieSandwich : Sandwich
    {
        public VeggieSandwich()
        {
            Description = "Veggie Sandwich";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double GetPrize()
        {
            return 3.45;
        }
    }
}
