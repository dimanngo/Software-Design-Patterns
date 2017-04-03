using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Standard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of threads:");
            Int32.TryParse(Console.ReadLine(), out int countThreads);

            Console.WriteLine($"Program will continue to work with {countThreads} thread" + (countThreads > 1 ? "s." : "."));
            Console.WriteLine("Please press <ENTER> to continue.");
            Console.ReadLine();

            for (int i = 0; i < countThreads; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(runSingleton), i);
            }

            Console.ReadLine();
        }

        private static void runSingleton(object state)
        {
            var instance = Singleton.GetInstance();
            Console.WriteLine($"Count of active instances: {Singleton.countInstances}");
        }
    }
}
