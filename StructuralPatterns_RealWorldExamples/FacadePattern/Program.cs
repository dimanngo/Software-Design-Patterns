using FacadePattern.Facade;

namespace FacadePattern
{
    class Program
    {
        static void Main()
        {
            var computer = new Computer();
            computer.Start();
        }
    }
}
