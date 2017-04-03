using System;
using System.Collections.Generic;

namespace Visitor
{
    static class Program
    {
        static void Main()
        {
            var objectStructure = new ObjectStructure();
            objectStructure.Attach(new ConcreteElementA());
            objectStructure.Attach(new ConcreteElementB());
            objectStructure.Accept(new ConcreteVisitorA());
            objectStructure.Accept(new ConcreteVisitorB());
        }
    }
    
    public abstract class ElementBase
    {
        public abstract void Accept(VisitorBase visitor);
    }
    
    public abstract class VisitorBase
    {
        public abstract void Visit(ConcreteElementA element);

        public abstract void Visit(ConcreteElementB element);
    }

    public class ObjectStructure
    {
        private List<ElementBase> _elements;

        public ObjectStructure()
        {
            _elements = new List<ElementBase>();
        }

        public void Accept(VisitorBase visitor)
        {
            foreach (ElementBase element in _elements)
            {
                element.Accept(visitor);
            }
        }

        public void Attach(ElementBase element)
        {
            _elements.Add(element);
        }

        public void Detach(ElementBase element)
        {
            _elements.Remove(element);
        }
    }

    public class ConcreteElementA : ElementBase
    {
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);
        }

        public string Name { get; set; }
    }


    public class ConcreteElementB : ElementBase
    {
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);
        }

        public string Title { get; private set; }
    }

    public class ConcreteVisitorA : VisitorBase
    {
        public override void Visit(ConcreteElementA element)
        {
            Console.WriteLine("VisitorA visited ElementA : {0}", element.Name);
        }

        public override void Visit(ConcreteElementB element)
        {
            Console.WriteLine("VisitorA visited ElementB : {0}", element.Title);
        }
    }


    public class ConcreteVisitorB : VisitorBase
    {
        public override void Visit(ConcreteElementA element)
        {
            Console.WriteLine("VisitorB visited ElementA : {0}", element.Name);
        }

        public override void Visit(ConcreteElementB element)
        {
            Console.WriteLine("VisitorB visited ElementB : {0}", element.Title);
        }
    }
}
