using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPattern.Interpreter
{
    public class TerminalExpression : IExpression
    {
        private string data;
        public TerminalExpression(string data)
        {
            this.data = data;
        }

        public bool Interpret(string context)
        {
            return context.Contains(data);
        }
    }
}