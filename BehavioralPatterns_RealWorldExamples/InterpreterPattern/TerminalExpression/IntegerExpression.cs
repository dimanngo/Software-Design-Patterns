using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterpreterPattern.ExpressionBase;

namespace InterpreterPattern.TerminalExpression
{
    public class IntegerExpression:ExpressionBase.IExpressionBase
    {
        int _value;

        public IntegerExpression(int value)
        {
            _value = value;
        }

        public int Evaluate()
        {
            return _value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
