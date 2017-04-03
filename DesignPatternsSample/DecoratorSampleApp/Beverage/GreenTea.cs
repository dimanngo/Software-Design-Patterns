namespace DecoratorSampleApp.Beverage
{
    class GreenTea :BeverageBase
    {
        public GreenTea()
        {
            Description = "Green leaf tea";
        }
        public override double GetCost()
        {
            return 125;
        }
    }
}
