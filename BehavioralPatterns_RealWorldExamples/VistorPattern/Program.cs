using VistorPattern.ConcreteVisitors;
using VistorPattern.ObjectStructure;

namespace VistorPattern
{
    class Program
    {
        static void Main()
        {

            var visitor = new CarElementPrintVisitor();

            var car = new Car();
            car.Accept(visitor);
        }
    }
}
