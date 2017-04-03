using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VistorPattern.ElementBase;
using VistorPattern.VisitorBase;

namespace VistorPattern.ConcreteElements
{
    public class Transmission : IElementBase
    {
        public Transmission(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Accept(IVisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }
}
