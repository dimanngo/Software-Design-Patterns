using DecoratorSampleApp.Beverage;

namespace DecoratorSampleApp.Decorator
{
    class MilkCondiment: CondimentsDecoratorBase
    {
        private readonly BeverageBase _beverage;

        public MilkCondiment(BeverageBase beverage)
        {
            _beverage = beverage;
            Description = _beverage.Description + " + Milk";
        }
        public override double GetCost()
        {
            return _beverage.GetCost() + 50;
        }
    }
}
