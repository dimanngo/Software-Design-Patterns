using CommandPattern.CommandBase;
using CommandPattern.Receiver;

namespace CommandPattern.ConcreteCommands
{
    public class TakeSampleCommand : RobotCommandBase
    {
        public bool TakeSample { get; set; }

        public TakeSampleCommand(Robot robot) : base(robot) { }

        public override void Execute()
        {
            _robot.TakeSample(true);
        }

        public override void Undo()
        {
            _robot.TakeSample(false);
        }
    }
}
