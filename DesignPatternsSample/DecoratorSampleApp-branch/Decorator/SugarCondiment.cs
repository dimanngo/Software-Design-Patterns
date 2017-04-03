using DecoratorSampleApp.Beverage;

namespace DecoratorSampleApp.Decorator
{
    class SugarCondiment : CondimentsDecoratorBase
    {
        private readonly BeverageBase _beverage;

        public SugarCondiment(BeverageBase beverage)
        {
            _beverage = beverage;
            Description = _beverage.Description + " + Sugar";
        }
        public override double GetCost()
        {
            return _beverage.GetCost() + 10;
        }
    }
}
