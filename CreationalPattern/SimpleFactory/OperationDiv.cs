namespace DesignPattern.SimpleFactory
{
    public class OperationDiv : IOperator
    {
        public double GetResult(double numberOne, double numberTwo)
        {
            return numberOne / numberTwo;
        }
    }
}