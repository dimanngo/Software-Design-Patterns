using VistorPattern.ElementBase;
using VistorPattern.VisitorBase;

namespace VistorPattern.ConcreteElements
{
    public class Engine : IElementBase
    {

        public Engine(string name)
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
