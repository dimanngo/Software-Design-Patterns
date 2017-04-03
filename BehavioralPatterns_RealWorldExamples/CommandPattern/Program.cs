using CommandPattern.ConcreteCommands;
using CommandPattern.Invoker;
using CommandPattern.Receiver;

namespace CommandPattern
{
    class Program
    {
        static void Main()
        {
            var robot = new Robot();
            var controller = new RobotController();

            var move = new MoveCommand(robot);
            move.ForwardDistance = 1000;
            controller.Commands.Enqueue(move);

            var rotate = new RotateLeftCommand(robot);
            rotate.LeftRotationAngle = 45;
            controller.Commands.Enqueue(rotate);

            var scoop = new TakeSampleCommand(robot);
            scoop.TakeSample = true;
            controller.Commands.Enqueue(scoop);

            controller.ExecuteCommands();
            controller.UndoCommands(3);
        }
    }
}
