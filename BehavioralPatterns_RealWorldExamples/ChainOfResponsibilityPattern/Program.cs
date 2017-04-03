using System;
using ChainOfResponsibilityPattern.ConcreteHandlers;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main()
        {
            var h5 = new FivePenceHandler();
            var h10 = new TenPenceHandler();
            var h20 = new TwentyPenceHandler();
            var h50 = new FiftyPenceHandler();
            var h100 = new OnePoundHandler();
            h5.SetSuccessor(h10);
            h10.SetSuccessor(h20);
            h20.SetSuccessor(h50);
            h50.SetSuccessor(h100);

            var tenPence = new Coin { Diameter = 24.49F, Weight = 6.5F };
            var fiftyPence = new Coin { Diameter = 27.31F, Weight = 8.01F };
            var counterfeitPound = new Coin { Diameter = 22.5F, Weight = 9F };

            Console.WriteLine(h5.EvaluateCoin(tenPence)); 
            Console.WriteLine(h5.EvaluateCoin(fiftyPence));
            Console.WriteLine(h5.EvaluateCoin(counterfeitPound));
        }
    }

    public enum CoinEvaluationResult
    {
        Accepted,
        Rejected
    }
}
