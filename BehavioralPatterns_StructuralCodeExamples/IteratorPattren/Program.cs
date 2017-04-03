using System;
using System.Collections;

namespace Iterator
{
    static class Program
    {
        static void Main()
        {
            var aggregate = new ConcreteAggregate();
            aggregate[0] = "Item 1";
            aggregate[1] = "Item 2";
            aggregate[2] = "Item 3";
            aggregate[3] = "Item 4";


            var itorator = new ConcreteIterator(aggregate);


            object item = itorator.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = itorator.Next();
            }
        }
    }
    abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }

    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }

    class ConcreteIterator : Iterator
    {
        private readonly ConcreteAggregate _aggregate;
        private int _current;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }

            return ret;
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }
    }

    class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList _items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}
