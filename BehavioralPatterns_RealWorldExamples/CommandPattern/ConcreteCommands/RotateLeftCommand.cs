using CommandPattern.CommandBase;
using CommandPattern.Receiver;

namespace CommandPattern.ConcreteCommands
{
    public class RotateLeftCommand : RobotCommandBase
    {
        public double LeftRotationAngle { get; set; }

        public RotateLeftCommand(Robot robot) : base(robot) { }

        public override void Execute()
        {
            _robot.RotateLeft(LeftRotationAngle);
        }

        public override void Undo()
        {
            _robot.RotateRight(LeftRotationAngle);
        }
    }
}
