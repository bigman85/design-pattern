namespace DesignPattern.CreationalPattern.SimpleFactory
{
    public class OperationMul : IOperator
    {
        public double GetResult(double numberOne, double numberTwo)
        {
            return numberOne * numberTwo;
        }
    }
}