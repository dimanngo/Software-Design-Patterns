using System;
using ChainOfResponsibilityPattern.HandlerBase;

namespace ChainOfResponsibilityPattern.ConcreteHandlers
{
    class FiftyPenceHandler : CoinHandlerBase
    {
        public override CoinEvaluationResult EvaluateCoin(Coin coin)
        {
            if (Math.Abs(coin.Weight - 8) < 0.02 && Math.Abs(coin.Diameter - 27.3) < 0.15)
            {
                Console.WriteLine("Captured 50p");
                return CoinEvaluationResult.Accepted;
            }
            if (_successor != null)
            {
                return _successor.EvaluateCoin(coin);
            }
            return CoinEvaluationResult.Rejected;
        }
    }
}