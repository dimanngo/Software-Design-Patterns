using System;

namespace Decorator
{
    static class Program
    {
        static void Main()
        {
            var component = new ConcreteComponent();
            var decorator = new ConcreteDecorator(component);
            decorator.Operation();
        }
    }

    public abstract class ComponentBase
    {
        public abstract void Operation();
    }

    class ConcreteComponent : ComponentBase
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }

    public abstract class DecoratorBase : ComponentBase
    {
        private readonly ComponentBase _component;

        protected DecoratorBase(ComponentBase component)
        {
            _component = component;
        }

        public override void Operation()
        {
            _component.Operation();
        }
    }

    public class ConcreteDecorator : DecoratorBase
    {
        public ConcreteDecorator(ComponentBase component) : base(component) { }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("[ADDITIONAL CODE BLOCK]");
        }
    }
}
