using System;
using StrategyPattern.StrategyBase;

namespace StrategyPattern.ConcreteStretegies
{
    public class DefensiveBehaviour:IRobotBehaviour
    {
        public void Move()
        {
            Console.WriteLine("\tDefensive Behaviour: if find another robot, run from it");
        }
    }
}
