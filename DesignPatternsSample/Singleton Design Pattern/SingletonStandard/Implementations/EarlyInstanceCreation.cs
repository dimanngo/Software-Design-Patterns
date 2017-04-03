/*
 * Early instance creation.
 * We can choose to create the instance of Singleton class when the class is loaded.
 * This is thread-safe without using locking.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton.Implementations
{
    public class EarlyInstanceCreation : ISingleton
    {
        private static int countInstances = 0;
        private static EarlyInstanceCreation instance = new EarlyInstanceCreation();

        int ISingleton.CountInstances => countInstances;

        private EarlyInstanceCreation()
        {
            if (instance != null)
            {
                throw new Exception("Cannot create singleton instance through reflection or something went wrong :(");
            }

            Interlocked.Increment(ref countInstances);
        }

        ~EarlyInstanceCreation()
        {
            Interlocked.Decrement(ref countInstances);
        }

        public static ISingleton GetInstance()
        {
            return instance;
        }
    }
}
