namespace DesignPattern.CreationalPattern.SimpleFactory
{
    public class OperatorFactory
    {
        public IOperator GetOperator(string type)
        {
            IOperator oper;
            switch (type)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
                default:
                    throw new Exception($"Error operator [{type}]");

            }

            return oper;
        }
    }
}