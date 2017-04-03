using System;

namespace Template
{
    static class Program
    {
        static void Main()
        {

            AlgorithmBase algorithmBase1 = new ConcreteAlgorithmA();
            algorithmBase1.TemplateMethod();

            AlgorithmBase algorithmBase2 = new ConcreteAlgorithmB();
            algorithmBase2.TemplateMethod();
        }
    }

    public abstract class AlgorithmBase
    {
        public void TemplateMethod()
        {
            Step1();
            Step2();
            Step3();
        }

        protected abstract void Step1();

        protected abstract void Step2();

        protected abstract void Step3();
    }

    public class ConcreteAlgorithmA : AlgorithmBase
    {
        protected override void Step1()
        {
            Console.WriteLine("ConcreteAlgorithmA.Step1()");
        }

        protected override void Step2()
        {
            Console.WriteLine("ConcreteAlgorithmA.Step2()");
        }

        protected override void Step3()
        {
            Console.WriteLine("ConcreteAlgorithmA.Step3()");
        }
    }


    public class ConcreteAlgorithmB : AlgorithmBase
    {
        protected override void Step1()
        {
            Console.WriteLine("ConcreteAlgorithmB.Step1()");
        }

        protected override void Step2()
        {
            Console.WriteLine("ConcreteAlgorithmB.Step2()");
        }

        protected override void Step3()
        {
            Console.WriteLine("ConcreteAlgorithmB.Step3()");
        }
    }
}
