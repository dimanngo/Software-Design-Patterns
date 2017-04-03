/*
 * using Lazy<T> type.
 * You need to pass a delegate to the constructor which calls the Singleton constructor – 
 * which is done most easily with a lambda expression.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton.Implementations
{
    public class LazySingleton : ISingleton
    {
        private static int countInstances = 0;
        private static readonly Lazy<LazySingleton> lazyInstance = 
            new Lazy<LazySingleton>(() => new LazySingleton());

        int ISingleton.CountInstances => countInstances;

        private LazySingleton()
        {
            if (lazyInstance != null && countInstances > 0)
            {
                throw new Exception("Cannot create singleton instance through reflection or something went wrong :(");
            }

            Interlocked.Increment(ref countInstances);
        }

        ~LazySingleton()
        {
            Interlocked.Decrement(ref countInstances);
        }

        public static ISingleton GetInstance()
        {
            return lazyInstance.Value;
        }
    }
}
