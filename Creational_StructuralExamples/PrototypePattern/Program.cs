using System;

namespace Prototype
{
    static class Program
    {
        static void Main()
        {
            ConcretePrototype prototype = new ConcretePrototype("1");
            ConcretePrototype clone = (ConcretePrototype)prototype.Clone();
            Console.WriteLine("Cloned: {0}", clone.Id);
        }
    }

    abstract class Prototype
    {
        private readonly string _id;

        protected Prototype(string id)
        {
            _id = id;
        }

        public string Id
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }

    class ConcretePrototype : Prototype
    {
        public ConcretePrototype(string id)
            : base(id)
        {
        }
        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }

}
