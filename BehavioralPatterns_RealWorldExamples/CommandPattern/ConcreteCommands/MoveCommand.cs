using CommandPattern.CommandBase;
using CommandPattern.Receiver;

namespace CommandPattern.ConcreteCommands
{
    public class MoveCommand:RobotCommandBase
    {
        public int ForwardDistance { get; set; }

        public MoveCommand(Robot robot) : base(robot) { }

        public override void Execute()
        {
            _robot.Move(ForwardDistance);
        }

        public override void Undo()
        {
            _robot.Move(-ForwardDistance);
        }
    }
}
