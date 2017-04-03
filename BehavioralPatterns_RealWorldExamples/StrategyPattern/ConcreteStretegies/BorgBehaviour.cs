using System;
using StrategyPattern.StrategyBase;

namespace StrategyPattern.ConcreteStretegies
{
    public class BorgBehaviour:IRobotBehaviour
    {
        public void Move()
        {
            Console.WriteLine("\tBorg Behaviour: if find another robot, assimilate it");
        }
    }
}
