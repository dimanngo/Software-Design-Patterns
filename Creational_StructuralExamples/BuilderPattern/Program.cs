using System;
using System.Collections.Generic;

namespace Builder
{
    static class Program
    {
        static void Main()
        {
            Builder b1 = new ConcreteBuilder1();

            Director.Construct(b1);
            var p1 = b1.GetResult();
            p1.Show();
        }
    }

    static class Director
    {
        public static void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }

    class ConcreteBuilder1 : Builder
    {
        private readonly Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("Part A");
        }

        public override void BuildPartB()
        {
            _product.Add("Part B");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }    

    class Product
    {
        private readonly List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Parts:");
            foreach (string part in _parts)
                Console.WriteLine("\t"+part);
        }
    }
}
