using DecoratorSampleApp.Beverage;

namespace DecoratorSampleApp.Decorator
{
    class ChocolateCondiment : CondimentsDecoratorBase
    {
        private readonly BeverageBase _beverage;

        public ChocolateCondiment(BeverageBase beverage)
        {
            _beverage = beverage;
            Description = _beverage.Description + " + Chocolate";
        }
        public override double GetCost()
        {
            return _beverage.GetCost() + 70;
        }
    }
}
