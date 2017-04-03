using System;

namespace State
{
    static class Program
    {
        static void Main()
        {
            var context = new Context(new ConcreteStateA());
            context.Request();
            context.Request();
            context.Request();
            context.Request();
        }
    }

    public class Context
    {
        private StateBase _state;

        public Context(StateBase state)
        {
            _state = state;
            State = _state;
        }

        public void Request()
        {
            _state.Handle(this);
        }

        public StateBase State
        {
            set
            {
                _state = value;
                Console.WriteLine("Current state: {0}",_state.GetType());
            }
        }
    }

    public abstract class StateBase
    {
        public abstract void Handle(Context context);
    }

    class ConcreteStateA : StateBase
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }

    class ConcreteStateB : StateBase
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
