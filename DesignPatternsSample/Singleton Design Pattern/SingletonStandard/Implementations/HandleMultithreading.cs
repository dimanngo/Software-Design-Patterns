/* The standard singleton implementation code works fine in Single threaded environment.
 * But in multithreaded environment, the GetInstance() code breaks.
 * If two threads enter the if condition at the same time, then two instances of Singleton will be created.
 * 
 * We can synchronize the method. So that only one thread can access it at a time.
 * In the below implementation, the thread locks out the shared object,
 * and then checks whether or not the instance has been created before creating the instance.
 */

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
            if (instance != null)
            {
                throw new Exception("Cannot create singleton instance through reflection or something went wrong :(");
            }

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
