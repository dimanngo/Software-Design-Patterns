using System;

namespace Facade
{
    static class Program
    {
        static void Main()
        {
            Facade facade = new Facade();
            facade.PerformAction();
        }
    }

    public class Facade
    {
        public void PerformAction()
        {
            var c1a = new Class1A();
            var c1b = new Class1B();
            var c2a = new Class2A();
            var c2b = new Class2B();

            var result1a = c1a.Method1A();
            var result1b = c1b.Method1B(result1a);
            var result2a = c2a.Method2A(result1a);
            c2b.Method2B(result1b, result2a);
        }
    }

    public class Class1A
    {
        public int Method1A()
        {
            Console.WriteLine("Class1A.Method1A return value: 1");
            return 1;
        }
    }


    public class Class1B
    {
        public int Method1B(int param)
        {
            Console.WriteLine("Class1B.Method1B return value: {0}",param+1);
            return param+1;
        }
    }


    public class Class2A
    {
        public int Method2A(int param)
        {
            Console.WriteLine("Class2A.Method2A return value: {0}",param+2);
            return param+2;
        }
    }


    public class Class2B
    {
        public void Method2B(int param1, int param2)
        {
            Console.WriteLine("Class2B.Method2B return value: {0}", param1+param2 );
        }
    }
}
