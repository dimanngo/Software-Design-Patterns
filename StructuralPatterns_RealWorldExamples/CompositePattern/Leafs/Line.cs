using System;
using CompositePattern.Component;

namespace CompositePattern.Leafs
{
    public class Line : IShape
    {
        public Line(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Render(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }
    }
}
