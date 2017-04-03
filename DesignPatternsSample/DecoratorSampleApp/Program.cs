using System;
using DecoratorSampleApp.Beverage;
using DecoratorSampleApp.Decorator;

namespace DecoratorSampleApp
{
    /// <summary>
    /// Test 2
    /// </summary>
    class Program
    {
        static void Main()
        {
            BeverageBase espresso = new Espresso();
            BeverageBase blackTea = new BlackTea();
            BeverageBase greenTea = new GreenTea();

            Print(espresso);
            Print(blackTea);
            Print(greenTea);

            Console.WriteLine("-------------------------");

            BeverageBase capuccino = new SugarCondiment(new MilkCondiment(new Espresso()));
            Print(capuccino);

            BeverageBase greenTeaWithSugar = new SugarCondiment(new GreenTea());
            Print(greenTeaWithSugar);

        }

        static void Print(BeverageBase beverage)
        {
            Console.WriteLine("Beverage: {0}; Price: {1}", beverage.Description, beverage.GetCost());            
        }
    }
}
