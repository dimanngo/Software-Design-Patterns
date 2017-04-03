namespace DecoratorSampleApp.Beverage
{
    public abstract class BeverageBase
    {
        public string Description { get; protected set; }

        public abstract double GetCost();
    }
}
