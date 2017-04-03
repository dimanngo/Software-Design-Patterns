using System;

namespace Memento
{
    static class Program
    {
        static void Main()
        {
            var originator = new Originator {State = "State A"};
            Console.WriteLine(originator.State);
            var caretaker = new Caretaker {Memento = originator.CreateMemento()};
            originator.State = "State B";
            Console.WriteLine(originator.State);
            originator.SetMemento(caretaker.Memento);
            Console.WriteLine(originator.State);
        }
    }

    class Originator
    {
        private string _state;

        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
            }
        }

        public Memento CreateMemento()
        {
            return (new Memento(_state));
        }

        public void SetMemento(Memento memento)
        {
            State = memento.GetState();
        }
    }

    class Memento
    {
        private readonly string _state;

        public Memento(string state)
        {
            _state = state;
        }

        public string GetState()
        {
            return _state;

        }
    }

    class Caretaker
    {
        private Memento _memento;

        public Memento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}
