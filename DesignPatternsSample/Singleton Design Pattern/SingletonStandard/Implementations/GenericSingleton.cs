/*
 * Singleton Implementation using Generics.
 * This will give you a single instance and will effectively be lazy,
 * because the static constructor doesn’t get called until Build() is called.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton.Implementations
{
    public class GenericSingleton<T> where T: new() // T - must be singleton type
    {
        private static T instance = new T();
        
        public static T GetInstance()
        {
            return instance;
        }
    }
}
