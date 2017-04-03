using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern.Component
{
    public abstract class Sandwich
    {
        public abstract string GetDescription();

        public abstract double GetPrize();

        public string Description { get; set; }

    }
}
