using VistorPattern.ElementBase;
using VistorPattern.VisitorBase;

namespace VistorPattern.ConcreteElements
{
    public class Body : IElementBase
    {

        public Body(string  name)
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
