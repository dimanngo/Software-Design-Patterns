using System;

namespace Command
{
    class Program
    {
        static void Main()
        {
            Client client = new Client();
            client.RunCommand();
        }
    }

    public class Client
    {
        public void RunCommand()
        {
            var invoker = new Invoker();
            var receiver = new Receiver();
            var command = new ConcreteCommand(receiver);
            command.Parameter = "Hello, world!";
            invoker.Command = command;
            invoker.ExecuteCommand();
        }
    }

    public class Receiver
    {
        public void Action(string message)
        {
            Console.WriteLine("Action called with message, '{0}'.", message);
        }
    }


    public class Invoker
    {
        public CommandBase Command { get; set; }

        public void ExecuteCommand()
        {
            Command.Execute();
        }
    }

    public abstract class CommandBase
    {
        protected readonly Receiver _receiver;

        public CommandBase(Receiver receiver)
        {
            _receiver = receiver;
        }

        public abstract void Execute();
    }

    public class ConcreteCommand : CommandBase
    {
        public string Parameter { get; set; }

        public ConcreteCommand(Receiver receiver) : base(receiver) { }

        public override void Execute()
        {
            _receiver.Action(Parameter);
        }
    }
}
