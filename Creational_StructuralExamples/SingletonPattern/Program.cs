using System;

namespace Singleton
{
    static class Program
    {
        static void Main()
        {
            var singleton1 = Singleton.GetSingleton();
            var singleton2 = Singleton.GetSingleton();

            Console.WriteLine(singleton1==singleton2);

        }
    }

    public sealed class Singleton
    {
        private static volatile Singleton _instance;
        private static readonly object _lockThis = new object();

        private Singleton() { }

        public static Singleton GetSingleton()
        {
            if (_instance == null)
            {
                lock (_lockThis)
                {
                    if (_instance == null) _instance = new Singleton();
                }
            }
            return _instance;
        }
    }
}
