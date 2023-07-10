using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPattern.Interpreter
{
    public class AndExpression
    {
        private IExpression expressionLeft ;
        private IExpression expressionRight ;

        public AndExpression(IExpression expressionLeft, IExpression expressionRight)
        {
            this.expressionLeft = expressionLeft;
            this.expressionRight = expressionRight;
        }
        public bool Interpret(string context)
        {
            return expressionLeft.Interpret(context) && expressionRight.Interpret(context);
        }
    }
}