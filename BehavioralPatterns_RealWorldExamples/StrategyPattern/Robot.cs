using System;
using StrategyPattern.StrategyBase;

namespace StrategyPattern
{
    public class Robot
    {
        private readonly IRobotBehaviour _behaviour;
        private readonly string _name;
        public Robot(string name, IRobotBehaviour behaviour)
        {
            _behaviour = behaviour;
            _name = name;
        }

        public void Move()
        {
            Console.WriteLine(_name);
            _behaviour.Move();
        }
    }
}