using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandPattern.CommandBase;

namespace CommandPattern.Invoker
{
    public class RobotController
    {
        public Queue<RobotCommandBase> Commands;
        private Stack<RobotCommandBase> _undoStack;

        public RobotController()
        {
            Commands = new Queue<RobotCommandBase>();
            _undoStack = new Stack<RobotCommandBase>();
        }

        public void ExecuteCommands()
        {
            Console.WriteLine("EXECUTING COMMANDS.");

            while (Commands.Count > 0)
            {
                RobotCommandBase command = Commands.Dequeue();
                command.Execute();
                _undoStack.Push(command);
            }
        }

        public void UndoCommands(int numUndos)
        {
            Console.WriteLine("REVERSING {0} COMMAND(S).", numUndos);

            while (numUndos > 0 && _undoStack.Count > 0)
            {
                RobotCommandBase command = _undoStack.Pop();
                command.Undo();
                numUndos--;
            }
        }
    }
}
