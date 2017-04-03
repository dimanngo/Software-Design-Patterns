using System;
using SingletonPattern.Singleton;

namespace SingletonPattern
{
    class Program
    {
        static void Main()
        {
            var state = ApplicationState.GetState();
            state.LoginId = "kanasz";
            state.MaxSize = 1024;

            var state2 = ApplicationState.GetState();
            Console.WriteLine(state2.LoginId);      
            Console.WriteLine(state2.MaxSize);      
            Console.WriteLine(state == state2);    
        }
    }
}
