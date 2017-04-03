using System;

namespace Adapter
{
    static class Program
    {
        static void Main()
        {
            var client = new Client(new Adapter());
            client.Request();
        }

        public interface ITarget
        {
            void MethodA();
        }

        public class Client
        {
            private readonly ITarget _target;

            public Client(ITarget target)
            {
                _target = target;
            }

            public void Request()
            {
                _target.MethodA();
            }
        }

        public class Adaptee
        {
            public void MethodB()
            {
                Console.WriteLine("Adaptee's MethodB called");
            }
        }


        public class Adapter : ITarget
        {
            readonly Adaptee _adaptee = new Adaptee();

            public void MethodA()
            {
                _adaptee.MethodB();
            }
        }
    }
}
