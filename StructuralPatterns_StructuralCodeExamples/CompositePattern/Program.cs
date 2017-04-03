using System;
using System.Collections.Generic;

namespace Composite
{
    static class Program
    {
        static void Main()
        {
            var root = new Composite("root");
            root.AddChild(new Leaf("Leaf 1"));
            root.AddChild(new Leaf("Leaf 2"));

            var comp = new Composite("Composite C");
            comp.AddChild(new Leaf("Leaf C.1"));
            comp.AddChild(new Leaf("Leaf C.2"));

            root.AddChild(comp);
            root.AddChild(new Leaf("Leaf 3"));

            var leaf = new Leaf("Leaf 4");
            root.AddChild(leaf);
            root.RemoveChild(leaf);

            root.Display(1);
        }
    }

    public abstract class Component
    {
        protected readonly string name;

        protected Component(string name)
        {
            this.name = name;
        }

        public abstract void Operation();
        public abstract void Display(int depth);
    }

    class Composite : Component
    {
        private readonly List<Component> _children = new List<Component>();

        public Composite(string name)
            : base(name)
        {
        }

        public void AddChild(Component component)
        {
            _children.Add(component);
        }

        public void RemoveChild(Component component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Component component in _children)
            {
                component.Display(depth + 2);
            }
        }
        public override void Operation()
        {
            string message = string.Format("Composite with {0} child(ren).", _children.Count);
            Console.WriteLine(message);
        }
    }

    public class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        {
        }

        public override void Operation()
        {
            Console.WriteLine("Leaf.");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
