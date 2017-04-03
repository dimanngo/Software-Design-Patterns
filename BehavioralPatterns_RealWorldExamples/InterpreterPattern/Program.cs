using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterpreterPattern.NonterminalExpressions;
using InterpreterPattern.TerminalExpression;
using InterpreterPattern.ExpressionBase;
//http://www.blackwasp.co.uk/Interpreter.aspx
namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new Parser();

            var commands = new string[]
                                    {
                                        "+ 5 6",
                                        "- 6 5",
                                        "+ - 4 5 6",
                                        "+ 4 - 5 6",
                                        "+ - + - - 2 3 4 + - -5 6 + -7 8 9 10"
                                    };

            foreach (var command in commands)
            {
                ExpressionBase.IExpressionBase expression = parser.Parse(command);
                Console.WriteLine("{0} = {1}", expression, expression.Evaluate());
            }
        }
    }

    public class Parser
    {
        public ExpressionBase.IExpressionBase Parse(string polish)
        {
            var symbols = new List<string>(polish.Split(' '));
            return ParseNextExpression(symbols);
        }

        public ExpressionBase.IExpressionBase ParseNextExpression(List<string> symbols)
        {
            int value;
            if (int.TryParse(symbols[0], out value))
            {
                symbols.RemoveAt(0);
                return new IntegerExpression(value);
            }
            return ParseNonTerminalExpression(symbols);
        }

        private ExpressionBase.IExpressionBase ParseNonTerminalExpression(List<string> symbols)
        {
            var symbol = symbols[0];
            symbols.RemoveAt(0);

            var expr1 = ParseNextExpression(symbols);
            var expr2 = ParseNextExpression(symbols);

            switch (symbol)
            {
                case "+":
                    return new AdditionExpression(expr1, expr2);
                case "-":
                    return new SubtractionExpression(expr1, expr2);
                default:
                    string message = string.Format("Invalid Symbol ({0})", symbol);
                    throw new InvalidOperationException(message);
            }
        }
    }
}
