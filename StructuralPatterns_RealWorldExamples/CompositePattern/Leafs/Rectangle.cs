using System;
using CompositePattern.Component;

namespace CompositePattern.Leafs
{
    public class Rectangle:IShape
    {
        public Rectangle(string name)
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
