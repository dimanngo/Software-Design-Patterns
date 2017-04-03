using System;

namespace Strategy
{
    static class Program
    {
        static void Main()
        {
            var client = new Client {Strategy = new ConcreteStrategyA()};
            client.CallAlgorithm();
            client.Strategy = new ConcreteStrategyB();
            client.CallAlgorithm();
        }
    }

    public class Client
    {
        public StrategyBase Strategy { private get; set; }

        public void CallAlgorithm()
        {
            Strategy.Algorithm();
        }
    }


    public abstract class StrategyBase
    {
        public abstract void Algorithm();
    }


    public class ConcreteStrategyA : StrategyBase
    {
        public override void Algorithm()
        {
            Console.WriteLine("Concrete Strategy A");
        }
    }


    public class ConcreteStrategyB : StrategyBase
    {
        public override void Algorithm()
        {
            Console.WriteLine("Concrete Strategy B");
        }
    }
}
