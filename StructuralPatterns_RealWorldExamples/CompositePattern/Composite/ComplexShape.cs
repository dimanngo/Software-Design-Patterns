using System;
using System.Collections.Generic;
using CompositePattern.Component;

namespace CompositePattern.Composite
{
    public class ComplexShape:IShape
    {
        public ComplexShape(string name)
        {
            Name = name;
        }

        private readonly List<IShape> _shapes = new List<IShape>();

        public string Name { get; set; }

        public void Render(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
            foreach (var shape in _shapes)
            {
                shape.Render(depth+1);
            }
        }

        public void AddShape(IShape shape)
        {
            _shapes.Add(shape);
        }

        public void RemoveShape(IShape shape)
        {
            _shapes.Remove(shape);
        }
    }
}
