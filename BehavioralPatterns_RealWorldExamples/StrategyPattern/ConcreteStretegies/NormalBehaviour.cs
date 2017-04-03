using System;
using StrategyPattern.StrategyBase;

namespace StrategyPattern.ConcreteStretegies
{
    public class NormalBehaviour:IRobotBehaviour
    {
        public void Move()
        {
            Console.WriteLine("\tNormal Behaviour: if find another robot, ignore it");
        }
    }
}
