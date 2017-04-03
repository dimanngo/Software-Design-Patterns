namespace DecoratorSampleApp.Beverage
{
    public class BlackTea : BeverageBase
    {
        public BlackTea()
        {
            Description = "Black tean from teabag";
        }
        public override double GetCost()
        {
            return 25;
        }
    }
}
