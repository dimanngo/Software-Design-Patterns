using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MementoPattern.Memento;
using MementoPattern.Originator;

namespace MementoPattern.Caretaker
{
    public class PersonCaretaker
    {
        readonly Stack<PersonMemento> _mementos = new Stack<PersonMemento>();

        public PersonMemento GetMemento()
        {
            return _mementos.Pop();
        }

        public void Add(PersonMemento memento)
        {
            _mementos.Push(memento);
        }
    }
}
