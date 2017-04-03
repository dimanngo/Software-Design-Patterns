using System.Collections.Generic;
using VistorPattern.ConcreteElements;
using VistorPattern.ElementBase;
using VistorPattern.VisitorBase;

namespace VistorPattern.ObjectStructure
{
    public class Car : IElementBase
    {
        private readonly List<IElementBase> _parts;

        public Car()
        {
            _parts=new List<IElementBase>
                       {
                           new Wheel("Front Left"){Tire = "Michelin Pilot Super Sport"},
                           new Wheel("Front Right"){Tire = "Michelin Pilot Super Sport"},
                           new Wheel("Back Left"){Tire = "Michelin Pilot Super Sport"},
                           new Wheel("Back Right"){Tire = "Michelin Pilot Super Sport"},
                           new Engine("3.3 TDI 225"),
                           new Body("4-door sedan"),
                           new Transmission("5-speed manual")
                       };
        }

        public void Accept(IVisitorBase visitor)
        {
            foreach (var part in _parts)
            {
                part.Accept(visitor);
            }
        }
    }
}
