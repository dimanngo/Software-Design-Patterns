using CommandPattern.CommandBase;
using CommandPattern.Receiver;

namespace CommandPattern.ConcreteCommands
{
    public class RotateRightCommand : RobotCommandBase
    {
        public double RightRotationAngle { get; set; }

        public RotateRightCommand(Robot robot) : base(robot) { }

        public override void Execute()
        {
            _robot.RotateRight(RightRotationAngle);
        }

        public override void Undo()
        {
            _robot.RotateLeft(RightRotationAngle);
        }
    }
}
