﻿/*
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

namespace Standard
{
    public class Singleton
    {
        private static Singleton instance;
        public static int countInstances = 0;

        private Singleton()
        {
            Interlocked.Increment(ref countInstances);
        }

        ~Singleton()
        {
            Interlocked.Decrement(ref countInstances);
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
}
