using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton.Implementations
{
    public sealed class HandleMultithreadingDblCheck : ISingleton
    {
        private static HandleMultithreadingDblCheck instance = null;
        private static int countInstances = 0;
        private static readonly object Instancelock = new object();

        private HandleMultithreadingDblCheck()
        {
            Interlocked.Increment(ref countInstances);
        }

        ~HandleMultithreadingDblCheck()
        {
            Interlocked.Decrement(ref countInstances);
        }

        public int CountInstances => countInstances;

        public static HandleMultithreadingDblCheck GetInstance()
        {
            if (instance == null)
            {
                lock (Instancelock)
                {
                    if (instance == null)
                    {
                        instance = new HandleMultithreadingDblCheck();
                    }
                }
            }

            return instance;
        }
    }
}
