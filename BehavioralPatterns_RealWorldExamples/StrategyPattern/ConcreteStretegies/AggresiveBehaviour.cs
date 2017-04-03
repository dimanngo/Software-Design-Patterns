using System;
using StrategyPattern.StrategyBase;

namespace StrategyPattern.ConcreteStretegies
{
    public class AggresiveBehaviour:IRobotBehaviour
    {
        public void Move()
        {
            Console.WriteLine("\tAggresive Behaviour: if find another robot, attack it");
        }
    }
}
