using VistorPattern.ElementBase;
using VistorPattern.VisitorBase;

namespace VistorPattern.ConcreteElements
{
    public class Wheel : IElementBase
    {

        public Wheel(string  name)
        {
            Name = name;
        }

        public string Tire { get; set; }

        public string Name { get; set; }

        public void Accept(IVisitorBase visitor)
        {
            visitor.Visit(this);
        }

        void IElementBase.Accept(IVisitorBase visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
