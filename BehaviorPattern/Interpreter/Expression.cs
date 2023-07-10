using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPattern.Interpreter
{
    public interface IExpression
    {
        bool Interpret(string context);
    }
}