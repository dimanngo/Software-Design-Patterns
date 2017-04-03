using System;

namespace Interpreter
{
    static class Program
    {
        static void Main()
        {
            Client.BuildAndInterpretCommands();
        }
    }

    public static class Client
    {
        public static void BuildAndInterpretCommands()
        {
            var context = new Context("hello world!!!");
            var root = new NonterminalExpression
                           {
                               Expression1 = new TerminalExpression(),
                               Expression2 = new TerminalExpression()
                           };
            root.Interpret(context);
        }
    }

    public class Context
    {
        public string Name { get; set; }

        public Context(string name)
        {
            Name = name;
        }
    }

    public abstract class ExpressionBase
    {
        public abstract void Interpret(Context context);
    }


    public class TerminalExpression : ExpressionBase
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Terminal for {0}.", context.Name);
        }
    }


    public class NonterminalExpression : ExpressionBase
    {
        public ExpressionBase Expression1 { get; set; }

        public ExpressionBase Expression2 { get; set; }

        public override void Interpret(Context context)
        {
            Console.WriteLine("Nonterminal for {0}.", context.Name);
            Expression1.Interpret(context);
            Expression2.Interpret(context);
        }
    }
}
