using StrategyPattern.ConcreteStretegies;

namespace StrategyPattern
{
    class Program
    {
        static void Main()
        {
            var robot1 = new Robot("4of11", new BorgBehaviour());
            var robor2 = new Robot("Military Robot", new AggresiveBehaviour());
            var robot3 = new Robot("rotoROBOt", new NormalBehaviour());

            robot1.Move();
            robor2.Move();
            robot3.Move();
        }
    }
}
