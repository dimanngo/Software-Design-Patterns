using System;
using System.Threading;

namespace FacadePattern.Subsystems
{
    public class Memory
    {
        public void Load(long position, byte[] data)
        {
            Console.WriteLine("Loading data: ");
            foreach (var b in data)
            {
                Console.Write(b+ " ");
                Thread.Sleep(1000);
            }

            Console.WriteLine("\nLoading compleded");
        }
    }
}
