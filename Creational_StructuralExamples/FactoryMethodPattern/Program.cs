using System;

namespace FactoryMethod
{
    static class Program
    {
        static void Main()
        {
            FactoryBase factory = new ConcreteFactory();
            ProductBase product = factory.FactoryMethod(1);
            product.ShowInfo();
            product = factory.FactoryMethod(2);
            product.ShowInfo();
        }
    }

    public abstract class FactoryBase
    {
        public abstract ProductBase FactoryMethod(int type);
    }

    public class ConcreteFactory : FactoryBase
    {
        public override ProductBase FactoryMethod(int type)
        {
            switch (type)
            {
                case 1: 
                    return new ConcreteProduct1();
                case 2: 
                    return new ConcreteProduct2();
                default: 
                    throw new ArgumentException("Invalid type.", "type");
            }
        }
    }


    public abstract class ProductBase
    {
        public abstract void ShowInfo();
    }

    public class ConcreteProduct1 : ProductBase {
        public override void ShowInfo()
        {
            Console.WriteLine("Product1");
        }
    }

    public class ConcreteProduct2 : ProductBase {
        public override void ShowInfo()
        {
            Console.WriteLine("Product2");
        }
    }
}
