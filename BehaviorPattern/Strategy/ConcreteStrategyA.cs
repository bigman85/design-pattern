namespace DesignPattern.Strategy
{
    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Implemention of Algorithm A!");
        }
    }
}