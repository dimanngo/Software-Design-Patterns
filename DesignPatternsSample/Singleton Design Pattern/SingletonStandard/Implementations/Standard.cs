/*
 * To ensure the class has only one instance, we mark the constructor as private.
 * So, we can only instantiate this class from within the class.
 * 
 * We create a static variable that will hold the instance of the class.
 * Then, we create a static method that provides the instance of the singleton class.
 * This method checks if an instance of the singleton class is available.
 * It creates an instance, if its not available; Otherwise, it returns the available instance.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton.Implementations
{
    public class Standard : ISingleton
    {
        private static Standard instance;
        private static int countInstances = 0;

        int ISingleton.CountInstances => countInstances;

        private Standard()
        {
            Interlocked.Increment(ref countInstances);
        }

        ~Standard()
        {
            Interlocked.Decrement(ref countInstances);
        }

        public static ISingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Standard();
            }

            return instance;
        }
    }
}
