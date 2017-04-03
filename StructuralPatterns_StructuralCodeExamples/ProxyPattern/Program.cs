using System;

namespace Proxy
{
    static class Program
    {
        static void Main()
        {
            var proxy = new Proxy();
            proxy.Operation();
        }
    }

    public abstract class SubjectBase
    {
        public abstract void Operation();
    }

    public class RealSubject : SubjectBase
    {
        public override void Operation()
        {
            Console.WriteLine("RealSubject.Operation");
        }
    }

    public class Proxy : SubjectBase
    {
        private RealSubject _realSubject;

        public override void Operation()
        {
            if (_realSubject == null)
                _realSubject = new RealSubject();

            _realSubject.Operation();
        }
    }
}
