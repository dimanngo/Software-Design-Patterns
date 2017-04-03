using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandPattern.Receiver;

namespace CommandPattern.CommandBase
{
    public abstract class RobotCommandBase
    {
        protected Robot _robot;

        public RobotCommandBase(Robot robot)
        {
            _robot = robot;
        }

        public abstract void Execute();

        public abstract void Undo();
    }
}
