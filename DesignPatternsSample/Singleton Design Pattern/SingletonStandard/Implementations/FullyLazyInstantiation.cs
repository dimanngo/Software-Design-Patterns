/*
 * Fully Lazy Instantiation.
 * Here, instantiation is triggered by the first reference to the static member
 * of the GetInstance class, which only occurs in Instance.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton.Implementations
{
    public class FullyLazyInstantiation : ISingleton
    {
        private static int countInstances = 0;
        int ISingleton.CountInstances => countInstances;

        private FullyLazyInstantiation()
        {
            Interlocked.Increment(ref countInstances);
        }

        ~FullyLazyInstantiation()
        {
            Interlocked.Decrement(ref countInstances);
        }
        public static ISingleton GetInstance()
        {
            return GetInstanceClass.instance;
        }
        private class GetInstanceClass
        {
            // Explicit static constructor to tell compiler
            // not to mark type as before field hint
            static GetInstanceClass() { }

            internal static readonly FullyLazyInstantiation instance = new FullyLazyInstantiation();
        }
    }
}
