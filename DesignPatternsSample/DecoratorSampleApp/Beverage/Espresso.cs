namespace DecoratorSampleApp.Beverage
{
    public class Espresso : BeverageBase
    {
        public Espresso()
        {
            Description = "Small portion of strong coffee";
        }
        public override double GetCost()
        {
            return 150;
        }
    }
}
