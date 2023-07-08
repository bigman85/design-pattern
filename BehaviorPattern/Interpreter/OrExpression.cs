namespace DesignPattern.BehaviorPattern.Interpreter
{
    public class OrExpression : IExpression
    {
        private IExpression expressionLeft ;
        private IExpression expressionRight ;

        public OrExpression(IExpression expressionLeft, IExpression expressionRight)
        {
            this.expressionLeft = expressionLeft;
            this.expressionRight = expressionRight;
        }
        public bool Interpret(string context)
        {
            return expressionLeft.Interpret(context) || expressionRight.Interpret(context);
        }
    }
}