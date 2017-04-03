using System;
using ChainOfResponsibilityPattern.HandlerBase;

namespace ChainOfResponsibilityPattern.ConcreteHandlers
{
    class TwentyPenceHandler : CoinHandlerBase
    {
        public override CoinEvaluationResult EvaluateCoin(Coin coin)
        {
            if (Math.Abs(coin.Weight - 5) < 0.01 && Math.Abs(coin.Diameter - 21.4) < 0.1)
            {
                Console.WriteLine("Captured 20p");
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