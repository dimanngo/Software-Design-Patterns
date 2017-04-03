using System;
using System.Collections;

namespace Flyweight
{
    static class Program
    {
        static void Main()
        {
            int extrinsicstate = 22;

            var factory = new FlyweightFactory();
            var flyweightA = factory.GetFlyweight("A");
            flyweightA.StatefulOperation(--extrinsicstate);

            var flyweightB = factory.GetFlyweight("B");
            flyweightB.StatefulOperation(--extrinsicstate);

            var flyweightC = factory.GetFlyweight("C");
            flyweightC.StatefulOperation(--extrinsicstate);

            var unsharedFlyweight = new UnsharedFlyweight();
            unsharedFlyweight.StatefulOperation(--extrinsicstate);

        }
    }

    public abstract class FlyweightBase
    {
        public abstract void StatefulOperation(object o);
    }


    public class FlyweightFactory
    {
        private readonly Hashtable _flyweights = new Hashtable();

        public FlyweightBase GetFlyweight(string key)
        {
            if (_flyweights.Contains(key))
            {
                return _flyweights[key] as FlyweightBase;
            }
            var newFlyweight = new ConcreteFlyweight();

            _flyweights.Add(key, newFlyweight);
            return newFlyweight;
        }
    }


    public class ConcreteFlyweight : FlyweightBase
    {
        public override void StatefulOperation(object o)
        {
            Console.WriteLine(o);
        }
    }


    public class UnsharedFlyweight : FlyweightBase
    {
        private object _state;

        public override void StatefulOperation(object o)
        {
            _state = o;
            Console.WriteLine(_state);
        }
    }
}
