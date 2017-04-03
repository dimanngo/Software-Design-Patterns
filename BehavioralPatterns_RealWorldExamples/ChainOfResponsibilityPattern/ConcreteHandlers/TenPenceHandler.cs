using System;
using ChainOfResponsibilityPattern.HandlerBase;

namespace ChainOfResponsibilityPattern.ConcreteHandlers
{
    public class TenPenceHandler : CoinHandlerBase
    {
        public override CoinEvaluationResult EvaluateCoin(Coin coin)
        {
            if (Math.Abs(coin.Weight - 6.5) < 0.03 && Math.Abs(coin.Diameter - 24.5) < 0.15)
            {
                Console.WriteLine("Captured 10p");
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