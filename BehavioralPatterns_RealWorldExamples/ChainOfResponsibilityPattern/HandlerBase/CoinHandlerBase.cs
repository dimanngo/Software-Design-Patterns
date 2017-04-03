using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern.HandlerBase
{
    public abstract class CoinHandlerBase
    {
        protected CoinHandlerBase _successor;

        public void SetSuccessor(CoinHandlerBase successor)
        {
            _successor = successor;
        }

        public abstract CoinEvaluationResult EvaluateCoin(Coin coin);
    }
}
