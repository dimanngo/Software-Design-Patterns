using System;
using ChainOfResponsibilityPattern.HandlerBase;

namespace ChainOfResponsibilityPattern.ConcreteHandlers
{
    public class FivePenceHandler : CoinHandlerBase
    {

        public override CoinEvaluationResult EvaluateCoin(Coin coin)
        {
            if (Math.Abs(coin.Weight - 3.25) < 0.02 && Math.Abs(coin.Diameter - 18) < 0.1)
            {
                Console.WriteLine("Captured 5p");
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