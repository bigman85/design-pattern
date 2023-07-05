namespace DesignPattern.CreationalPattern.SimpleFactory
{
    public class OperationSub : IOperator
    {
        public double GetResult(double numberOne, double numberTwo)
        {
            return numberOne - numberTwo;
        }
    }
}