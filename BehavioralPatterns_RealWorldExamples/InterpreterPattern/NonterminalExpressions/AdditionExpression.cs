using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterpreterPattern.NonterminalExpressions
{
    public class AdditionExpression : ExpressionBase.IExpressionBase
    {
        ExpressionBase.IExpressionBase _expr1;
        ExpressionBase.IExpressionBase _expr2;

        public AdditionExpression(ExpressionBase.IExpressionBase expr1, ExpressionBase.IExpressionBase expr2)
        {
            _expr1 = expr1;
            _expr2 = expr2;
        }

        public int Evaluate()
        {
            int value1 = _expr1.Evaluate();
            int value2 = _expr2.Evaluate();
            return value1 + value2;
        }

        public override string ToString()
        {
            return string.Format("({0} + {1})", _expr1, _expr2);
        }
    }
}
