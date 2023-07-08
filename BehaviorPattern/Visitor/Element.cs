using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPattern.Visitor
{
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}