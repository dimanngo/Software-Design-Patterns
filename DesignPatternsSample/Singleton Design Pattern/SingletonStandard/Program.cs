using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeRepository(out Dictionary<int, string> repo);

            if (repo.Count == 0)
            {
                Console.WriteLine("Warning! There are no implementations of Singleton design pattern.");
                Console.ReadLine();
                return;
            }

            Console.Write($"Select singleton pattern implementation (number from 1 to {repo.Count}). 1 - is default option. ");
            Int32.TryParse(Console.ReadLine(), out int selectedOption);
            selectedOption = repo.ContainsKey(selectedOption) ? selectedOption : 1;
            Console.WriteLine($"Implementation '{repo[selectedOption]}' will be executed.");

            Console.Write("Enter the number of threads:");
            Int32.TryParse(Console.ReadLine(), out int countThreads);

            Console.WriteLine($"Program will continue to work with {countThreads} thread" + (countThreads > 1 ? "s." : "."));
            Console.WriteLine("Please press <ENTER> to continue.");
            Console.ReadLine();

            for (int i = 0; i < countThreads; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(runSingleton), repo[selectedOption]);
            }

            Console.ReadLine();
        }

        private static void InitializeRepository(out Dictionary<int, string> patternRepo)
        {
            patternRepo = new Dictionary<int, string>
            {
                { 1, typeof(Implementations.Standard).ToString()},
                { 2, typeof(Implementations.HandleMultithreading).ToString() },
                { 3, typeof(Implementations.HandleMultithreadingDblCheck).ToString() },
                { 4, typeof(Implementations.EarlyInstanceCreation).ToString() }
            };

            Console.WriteLine("Accessible Singleton Pattern implementations:");
            foreach (KeyValuePair<int, string> item in patternRepo)
            {
                Console.WriteLine($"{item.Key} \t-\t{item.Value}");
            }
        }
        
        private static void runSingleton(object singletonClassName)
        {
            var type = Type.GetType(singletonClassName as string);
            var method = type.GetMethod("GetInstance");
            var instance = method.Invoke(null, new object[] { }) as Implementations.ISingleton;
            Console.WriteLine($"Count of active instances: {instance.CountInstances}");
        }
    }
}
