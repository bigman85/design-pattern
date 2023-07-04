namespace DesignPattern.SimpleFactory
{
    public class OperationAdd : IOperator
    {
        public double GetResult(double numberOne, double numberTwo)
        {
            return numberOne + numberTwo;
        }
    }
}