using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton.Implementations
{
    public sealed class HandleMultithreading : ISingleton
    {
        private static HandleMultithreading instance = null;
        private static int countInstances = 0;
        private static readonly object Instancelock = new object();

        private HandleMultithreading()
        {
            Interlocked.Increment(ref countInstances);
        }

        ~HandleMultithreading()
        {
            Interlocked.Decrement(ref countInstances);
        }

        public int CountInstances => countInstances;

        public static HandleMultithreading GetInstance()
        {
            lock (Instancelock)
            {
                if (instance == null)
                {
                    instance = new HandleMultithreading();
                }
                return instance;
            }
        }
    }
}
