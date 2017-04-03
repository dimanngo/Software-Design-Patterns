using System;
using ChainOfResponsibilityPattern.HandlerBase;

namespace ChainOfResponsibilityPattern.ConcreteHandlers
{
    class OnePoundHandler : CoinHandlerBase
    {
        public override CoinEvaluationResult EvaluateCoin(Coin coin)
        {
            if (Math.Abs(coin.Weight - 9.5) < 0.02 && Math.Abs(coin.Diameter - 22.5) < 0.13)
            {
                Console.WriteLine("Captured £1");
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